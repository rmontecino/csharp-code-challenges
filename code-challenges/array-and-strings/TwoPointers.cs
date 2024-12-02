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
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

        public static int[] SortedSquares(int[] arr)
        {
            int n = arr.Length;
            int left = 0;
            int right = n - 1;
            int position = n - 1;
            int[] result = new int[n];

            while (left <= right)
            {
                int leftSquare = arr[left] * arr[left];
                int rightSquare = arr[right] * arr[right];

                if (leftSquare < rightSquare)
                {
                    result[position] = rightSquare;
                    right--;
                }
                else
                {
                    result[position] = leftSquare;
                    left++;
                }
                position--;
            }

            return result;
        }
    }
}