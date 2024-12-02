using CodeChallenges.ArrayAndStrings;

internal class Program
{
    private static void Main(string[] args)
    {
        // // Test the palindrome method
        // string s = "racecar";
        // Console.WriteLine(TwoPointers.CheckIfPalindrome(s));

        // Test the sorted squares method
        int[] arr = new int[] { -4, -1, 0, 3, 10 };
        int[] result = TwoPointers.SortedSquares(arr);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}