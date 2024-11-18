namespace XUnitTest
{
    
    public class LeapYearTest
    {

        
        [Theory]
        [InlineData(4)]
        [InlineData(1804)]
        [InlineData(2008)]
        [InlineData(2024)]
        [InlineData(2044)]
        [InlineData(2076)]
        public void ReturnTrueForLeapYears(int year)
        {
            Assert.True(LeapYear.LeapYear.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(1802)]
        [InlineData(2003)]
        [InlineData(2019)]
        [InlineData(2050)]
        [InlineData(2087)]
        public void ReturnFalseForNonLeapYears(int year)
        {
            Assert.False(LeapYear.LeapYear.IsLeapYear(year));
        }
    }
}