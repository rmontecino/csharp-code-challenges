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
    }
}