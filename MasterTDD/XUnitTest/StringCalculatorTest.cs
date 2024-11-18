
namespace XUnitTest
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Return_Error_for_Negetive_number()
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.StringCalculator.Add("-1"));
        }
        [Fact]
        public void Return_Zero_for_Empty_String()
        {
            Assert.Equal(0 , StringCalculator.StringCalculator.Add(""));
        }
        [Fact]
        public void Return_Number_for_One_Number()
        {
            Assert.Equal(5 , StringCalculator.StringCalculator.Add("5"));
        }
        [Fact]
        public void Return_Sum_for_Two_Numbers()
        {
            Assert.Equal(3 , StringCalculator.StringCalculator.Add("1,2"));
        }
        [Fact]
        public void Return_Sum_for_Three_Numbers_and_Newline()
        {
            Assert.Equal(6 , StringCalculator.StringCalculator.Add("1\n2,3"));
        }
        [Fact]
        public void Return_Sum_for_Four_Numbers_and_Newline_Instead_Commas()
        {
            Assert.Equal(13 , StringCalculator.StringCalculator.Add("1\n2\n3\n7"));
        }
        [Fact]
        public void Return_Sum_for_Number_with_Different_Delimiters ()
        {
            Assert.Equal(1 , StringCalculator.StringCalculator.Add("//;\n1"));
        }
        [Fact]
        public void Return_Sum_for_Two_Numbers_with_Different_Delimiters ()
        {
            Assert.Equal(3 , StringCalculator.StringCalculator.Add("//;\n1;2"));
        }
        [Fact]
        public void Return_Sum_for_Three_Numbers_with_Different_Delimiters ()
        {
            Assert.Equal(6 , StringCalculator.StringCalculator.Add("//;\n1;2;3"));
        }
        [Fact]
        public void Return_Sum_for_Three_Numbers_with_Different_Delimiters_Extra_Newline ()
        {
            Assert.Equal(6 , StringCalculator.StringCalculator.Add("//;\n1\n2;3"));
        }
        [Fact]
        public void Return_Sum_for_Three_Numbers_with_Different_Delimiters_WrongFormat ()
        {
            Assert.Throws<ArgumentException>(() =>  StringCalculator.StringCalculator.Add("//;1;\n2;3"));
        } 
        [Fact]
        public void Return_Sum_for_Three_Numbers_with_Different_Delimiters_No_Newline ()
        {
            Assert.Throws<ArgumentException>(() =>  StringCalculator.StringCalculator.Add("//;1;2;3"));
        }
        [Fact]
        public void Add_InvalidNumberFormat_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.StringCalculator.Add("1,\n"));
        }
    }
}