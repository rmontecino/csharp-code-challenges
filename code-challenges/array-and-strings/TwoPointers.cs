namespace CodeChallenges.ArrayAndStrings
{
    public class TwoPointers
    {
        public static void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                {
                    left++;
                    right--;
                }
            }
        }

        public static bool CheckIfPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}