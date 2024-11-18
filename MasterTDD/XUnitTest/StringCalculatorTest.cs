
namespace XUnitTest
{
    public class StringCalculatorTest
    {
        [Theory]
        [InlineData("-1")]
        [InlineData("-5")]
        [InlineData("-9")]
        public void Return_Error_for_Negative_Number(string input)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.StringCalculator.Add(input));
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("5", 5)]
        [InlineData("1,2", 3)]
        [InlineData("1,2,3", 6)]
        [InlineData("1,2,4,5", 12)]

        public void Return_Correct_Sum_for_Valid_Inputs(string input, int expected)
        {
            Assert.Equal(expected, StringCalculator.StringCalculator.Add(input));
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1\n2\n3\n7", 13)]
        public void Return_Sum_for_Mixed_Newline_and_Comma_Delimiters(string input, int expected)
        {
            Assert.Equal(expected, StringCalculator.StringCalculator.Add(input));
        }

        [Theory]
        [InlineData("//;\n1", 1)]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//;\n1;2;3", 6)]
        [InlineData("//;\n1\n2;3", 6)]
        public void Return_Sum_for_Custom_Delimiters(string input, int expected)
        {
            Assert.Equal(expected, StringCalculator.StringCalculator.Add(input));
        }

        [Theory]
        [InlineData("//;1;\n2;3")]
        [InlineData("//;1;2;3")]
        [InlineData("1,\n")]
        public void Return_Error_for_Invalid_Format(string input)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.StringCalculator.Add(input));
        }
    }
}