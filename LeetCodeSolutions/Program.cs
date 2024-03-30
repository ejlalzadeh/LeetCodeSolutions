using LeetCodeSolutions.Medium;

var matrix = new int[][]
{
    new int[] {1, 3, 5,7},
    new int[] {10,11,16,20},
    new int[] {23,30,34,60}
};

var matrix2 = new int[][]
{
    new int[] {1, 3, 5},
    new int[] {10,11,16},
    new int[] {23,30,34}
};


Console.WriteLine(SearchA2DMatrixSolution.SearchMatrix(matrix, 19));
;