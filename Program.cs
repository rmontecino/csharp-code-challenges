using CodeChallenges.ArrayAndStrings;

internal class Program
{
    private static void Main(string[] args)
    {
        // Test the MinStartValue method
        int[] nums = new int[] { -3, 2, -3, 4, 2 };
        int result = SlindingWindow.MinStartValue(nums);
        Console.WriteLine(result); // Output: 5
    }
}