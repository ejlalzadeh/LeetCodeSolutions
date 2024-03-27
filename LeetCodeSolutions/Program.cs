using LeetCodeSolutions.Medium;

IList<int> result = SpiralMatrixSolution.SpiralOrder(new[]
{
new[] { 1, 2, 3, 4 },
new[] { 5, 6, 7, 8 },
new[] { 9, 10, 11, 12 },
});

foreach (int item in result)
{
    Console.WriteLine(item);
}