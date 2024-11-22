namespace XUnitTest
{
    public class BowlingGameTests
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)] // Perfect game
        [InlineData("X|X|X|X|X|X|X|X|X|X||9-", 288)] // Strike then 9-
        [InlineData("X|X|X|X|X|X|X|X|X|X||X-", 290)] // Strike then one Strike
        [InlineData("X|X|X|X|X|X|X|X|X|X||9/", 289)] // Strike then Spare
        [InlineData("X|X|X|X|X|X|X|X|X|X||X9", 299)] // Strike then Strike and 9
        [InlineData("X|X|X|X|X|X|X|X|X|X||--", 270)] // Strike then --
        [InlineData("X|X|X|X|X|X|X|X|X|9/||5", 274)] // Almost perfect game, spare in the 10th frame
        [InlineData("X|X|X|X|X|X|X|X|X|9-|", 267)] // Almost perfect game, open in the 10th frame
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", 90)] // All 9
        [InlineData("5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||5", 150)] // All spares
        [InlineData("X|7/|9-|X|-8|8/|-6|X|X|X||81", 167)] // Mixed
        [InlineData("-|-|-|-|-|-|-|-|-|-|", 0)] // No pins knocked down in any frame
        [InlineData("X|5/|X|5/|X|5/|X|5/|X|5/||5", 195)] // Alternating strikes and spares
        [InlineData("1-|2-|3-|4-|5-|6-|7-|8-|9-|1-|", 46)] // Single-pin hits
        [InlineData("1-|2-|3-|4-|5-|6-|7-|8-|9-|X||81", 64)] // Low scores with a 10th frame strike
        [InlineData("X|7/|9-|X|X|X|X|X|X|9/||X", 237)]
        [InlineData("1-|1-|1-|1-|1-|1-|1-|1-|1-|1-||", 10)]
        public void CalculateScore_ReturnsExpectedScore(string game, int expected)
        {
            // Act
            int result = BowlingGame.BowlingGame.CalculateScore(game);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateScore_EmptyInput_ReturnsZero()
        {
            // Act
            int result =  BowlingGame.BowlingGame.CalculateScore("");

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateScore_InvalidFrame_ThrowsException()
        {
            // Act & Assert
            Assert.Throws<FormatException>(() =>  BowlingGame.BowlingGame.CalculateScore("X|X|X|X|X|X|X|X|X|X||XXY"));
        }
    }

}