using CodeChallenges.ArrayAndStrings;

internal class Program
{
    private static void Main(string[] args)
    {
        // Test the GetAverages method
        int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int k = 2;
        int[] result = SlindingWindow.GetAverages(nums, k);
        Console.WriteLine(string.Join(", ", result)); // Output: [-1, -1, 3, 4, 5, 6, 7, -1, -1]
    }
}