using CodeChallenges.ArrayAndStrings;

internal class Program
{
    private static void Main(string[] args)
    {
        // Test the two pointers method
        char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };
        TwoPointers.ReverseString(s);
        Console.WriteLine(s);
    }
}