namespace LeetCodeSolutions.Medium;

public class SearchA2DMatrixSolution
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        //Given a m*n matrix
        int m = matrix[0].Length;
        int n = matrix.Length;

        int targetRow = -1;

        for (int i = 0; i < n; i++)
        {
            int lastElementOfTheRow = matrix[i][m - 1];

            if (lastElementOfTheRow == target)
                return true;

            if (lastElementOfTheRow > target)
            {
                targetRow = i;
                break;
            }
        }

        if (targetRow == -1)
            return false;

        return Find(matrix[targetRow], target);

        bool Find(int[] array, int targetToBeFind)
        {
            if (array.Length == 0)
                return false;

            if (array.Length == 1)
            {
                return array[0] == targetToBeFind;
            }

            int medianIndex = array.Length / 2;
            int median = array[medianIndex];

            if (targetToBeFind == median)
                return true;

            if (targetToBeFind < median)
                return Find(array[0..medianIndex], targetToBeFind);
            else
                return Find(array[(medianIndex + 1)..array.Length], targetToBeFind);
        }
    }
}