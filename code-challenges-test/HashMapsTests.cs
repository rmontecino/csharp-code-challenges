using Xunit;

namespace CodeChallenges.Tests
{
    public class HashMapsTests
    {
        [Fact]
        public void TwoSum_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Act
            int[] result = HashMaps.HashMaps.TwoSum(nums, target);

            // Assert
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        // [Fact]
        // public void TwoSum_ReturnsNegativeOneWhenNoSolution()
        // {
        //     // Arrange
        //     int[] nums = { 1, 2, 3, 4 };
        //     int target = 8;

        //     // Act
        //     int[] result = HashMaps.HashMaps.TwoSum(nums, target);

        //     // Assert
        //     Assert.Equal(new int[] { -1, -1 }, result);
        // }

        // [Fact]
        // public void RepeatedCharacter_ReturnsFirstRepeatedCharacter()
        // {
        //     // Arrange
        //     string s = "abca";

        //     // Act
        //     char result = HashMaps.HashMaps.RepeatedCharacter(s);

        //     // Assert
        //     Assert.Equal('a', result);
        // }

        // [Fact]
        // public void RepeatedCharacter_ReturnsNullCharacterWhenNoRepetition()
        // {
        //     // Arrange
        //     string s = "abcdef";

        //     // Act
        //     char result = HashMaps.HashMaps.RepeatedCharacter(s);

        //     // Assert
        //     Assert.Equal('\0', result);
        // }

        // [Fact]
        // public void FindNumbers_ReturnsCorrectNumbers()
        // {
        //     // Arrange
        //     int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //     // Act
        //     List<int> result = HashMaps.HashMaps.FindNumbers(nums);

        //     // Assert
        //     Assert.Equal(new List<int> { 1, 10 }, result);
        // }
    }
}