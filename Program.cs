using CodeChallenges.ArrayAndStrings;

internal class Program
{
    private static void Main(string[] args)
    {
         // Test the RunningSum method
        int[] nums = new int[] { 1, 2, 3, 4 };
        int[] result = SlindingWindow.RunningSum(nums);
        Console.WriteLine(string.Join(", ", result)); // Output: 1, 3, 6, 10
    }
}