namespace CodeChallenges.HashMaps
{
    public class HashMaps
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            // Dictionary to store the numbers and their indices
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int complement = target - num;
                if (hashMap.ContainsKey(complement))
                {
                    return new int [] { hashMap[complement], i };
                }

                hashMap.Add(num, i);
            }
                
            return new[] { -1, -1 };
        }

        public static char RepeatedCharacter(string s)
        {
            HashSet<char> seen = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (seen.Contains(c))
                {
                    return c;
                }

                seen.Add(c);
            }

            return '\0';
        }

        public static List<int> FindNumbers(int[] nums)
        {
            List<int> ans = new List<int>();
            HashSet<int> numSet = [.. nums];

            foreach(int num in numSet)
            {
                if (!numSet.Contains(num + 1) && !numSet.Contains(num - 1))
                {
                    ans.Add(num);
                }
            }

            return ans;
        }

        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            HashSet<int> numSet = new HashSet<int>(nums);

            for (int i = 0; i <= n; i++)
            {
                if (!numSet.Contains(i))
                {
                    return i;
                }
            }

            return -1; // This line should never be reached if the input is valid
        }
    }
}