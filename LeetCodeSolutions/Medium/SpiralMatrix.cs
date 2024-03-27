namespace LeetCodeSolutions.Medium;

public class SpiralMatrixSolution
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        if (matrix is [{ Length: 1 }])
            return new List<int> { matrix[0][0] };

        List<int> spiralMatrix = new List<int>();
        int m = matrix[0].Length;
        int n = matrix.Length;
        int i = 0;
        int j = 0;
        var counter = 0;
        var totalItems = m * n;
        Dictionary<Tuple<int, int>, bool> visitedElements = new();

        while (counter < totalItems)
        {
            while (counter < totalItems)
            {
                visitedElements.Add(new Tuple<int, int>(i, j), true);
                spiralMatrix.Add(matrix[i][j]);
                counter++;

                if ((j + 1 < m && !visitedElements.ContainsKey(new Tuple<int, int>(i, j + 1))))
                    j++;
                else
                {
                    i++;

                    break;
                };
            }

            while (counter < totalItems)
            {
                visitedElements.Add(new Tuple<int, int>(i, j), true);
                spiralMatrix.Add(matrix[i][j]);
                counter++;

                if (i + 1 < n && !visitedElements.ContainsKey(new Tuple<int, int>(i + 1, j)))
                    i++;
                else
                {
                    j--;

                    break;
                }
            }

            while (counter < totalItems)
            {
                visitedElements.Add(new Tuple<int, int>(i, j), true);
                spiralMatrix.Add(matrix[i][j]);
                counter++;

                if (j - 1 >= 0 && !visitedElements.ContainsKey(new Tuple<int, int>(i, j - 1)))
                    j--;
                else
                {
                    i--;

                    break;
                }
            }

            while (counter < m * n)
            {
                visitedElements.Add(new Tuple<int, int>(i, j), true);
                spiralMatrix.Add(matrix[i][j]);
                counter++;

                if (i - 1 >= 0 && !visitedElements.ContainsKey(new Tuple<int, int>(i - 1, j)))
                    i--;
                else
                {
                    j++;

                    break;
                }
            }
        }

        return spiralMatrix;
    }
}