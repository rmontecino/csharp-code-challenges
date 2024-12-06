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
    }
}