namespace XUnitTest
{
    
    public class LeapYearTest
    {

        
        [Fact]
        public void ReturnTrueForYearFour()
        {
            Assert.True(LeapYear.LeapYear.IsLeapYear(4));  
        }
        
        [Fact]
        public void ReturnTrueForYear1804()
        {
            Assert.True(LeapYear.LeapYear.IsLeapYear(1804));  
        }
        
        [Fact]
        public void ReturnTrueForYear2008()
        {
            Assert.True(LeapYear.LeapYear.IsLeapYear(2008));  
        }
        [Fact]
        public void ReturnTrueForYear2024()
        {
            Assert.True(LeapYear.LeapYear.IsLeapYear(2024));  
        }
            [Fact]
        public void ReturnTrueForYear2044()
        {
            Assert.True(LeapYear.LeapYear.IsLeapYear(2044));  
        }
            [Fact]
        public void ReturnTrueForYear2076()
        {
            Assert.True(LeapYear.LeapYear.IsLeapYear(2076));  
        }
        [Fact]
        public void ReturnFalseForYearOne()
        {
            Assert.False(LeapYear.LeapYear.IsLeapYear(1));  
        }
        [Fact]
        public void ReturnFalseForYear1802()
        {
            Assert.False(LeapYear.LeapYear.IsLeapYear(1802));  
        }
        
        [Fact]
        public void ReturnFalseForYear2003()
        {
            Assert.False(LeapYear.LeapYear.IsLeapYear(2003));  
        }

        [Fact]
        public void ReturnFalseForYear2019()
        {
            Assert.False(LeapYear.LeapYear.IsLeapYear(2019));  
        }
        [Fact]
        public void ReturnFalseForYear2050()
        {
            Assert.False(LeapYear.LeapYear.IsLeapYear(2050));  
        }
        [Fact]
        public void ReturnFalseForYear2087()
        {
            Assert.False(LeapYear.LeapYear.IsLeapYear(2087));  
        }
    }
}