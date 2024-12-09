using CodeChallenges.ArrayAndStrings;

internal class Program
{
    private static void Main(string[] args)
    {
        // Test the longest ones method
        int[] nums = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
        int k = 2;
        Console.WriteLine(SlindingWindow.LongestOnes(nums, k));

    }
}