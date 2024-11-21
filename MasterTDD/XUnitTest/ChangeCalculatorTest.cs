namespace XUnitTest
{
    public class ChangeCalculatorTest
    {
        [Theory]
        [InlineData(1, 1, new double[] { 0 })]
        [InlineData(0.99, 1, new double[] { 0.01 })]
        [InlineData(10.95, 11, new double[] { 0.05 })]
        [InlineData(100.9, 101, new double[] { 0.1 })]
        [InlineData(10.75, 11, new double[] { 0.25 })]
        [InlineData(10.50, 11, new double[] { 0.50 })]
        [InlineData(199, 200, new double[] { 1 })]
        [InlineData(195, 200, new double[] { 5 })]
        [InlineData(190, 200, new double[] { 10 })]
        [InlineData(180, 200, new double[] { 20 })]
        [InlineData(150, 200, new double[] { 50 })]
        [InlineData(100, 200, new double[] { 100 })]
        [InlineData(74.75, 100, new double[] { 20, 5, 0.25 })]
        [InlineData(19.80, 20, new double[] { 0.10, 0.10 })]
        [InlineData(224.99, 500, new double[] { 100, 100, 50, 20, 5, 0.01 })]
        public void GetChange_ReturnsCorrectChange(double cost, double paid, double[] expected)
        {
            // Act
            var result = ChangeCalculator.ChangeCalculator.GetChange(cost, paid);

            // Assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(0.99, 0.50)]
        [InlineData(199, 150)]
        [InlineData(10.99, 10)]
        [InlineData(20.99, 20)]
        public void GetChange_ThrowsException_WhenPaidLessThanCost(double cost, double paid)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => ChangeCalculator.ChangeCalculator.GetChange(cost, paid));
        }

    }
}

