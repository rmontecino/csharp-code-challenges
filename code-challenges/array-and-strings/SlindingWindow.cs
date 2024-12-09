namespace CodeChallenges.ArrayAndStrings
{
    public class SlindingWindow
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            // Step 1: Calculate the sum of the first k elements
            double currentSum = 0;
            for (int i = 0; i < k; i++)
            {
                currentSum += nums[i];
            }

            // Step 2: Initialize maxSum to currentSum
            double maxSum = currentSum;

            // Step 3: Slide window through the array
            for (int i = k; i < nums.Length; i++)
            {
                currentSum = currentSum - nums[i - k] + nums[i];
                maxSum = Math.Max(currentSum, maxSum);
            }

            return maxSum / k;
        }

        public static int LongestOnes(int[] nums, int k)
        {
            // Step 1: Initialize the left and right pointers
            int left = 0;
            int right = 0;

            // Step 2: Initialize the maxCount and zeroCount
            int maxCount = 0;
            int zeroCount = 0;

            // Step 3: Slide the window through the array
            while (right < nums.Length)
            {
                // Step 4: If the current element is 0, increment zeroCount
                if (nums[right] == 0)
                {
                    zeroCount++;
                }

                // Step 5: If zeroCount is greater than k, increment left and decrement zeroCount
                while (zeroCount > k)
                {
                    if (nums[left] == 0)
                    {
                        zeroCount--;
                    }
                    left++;
                }

                // Step 6: Update maxCount
                maxCount = Math.Max(maxCount, right - left + 1);

                // Step 7: Increment right
                right++;
            }

            return maxCount;
        }
    }
}