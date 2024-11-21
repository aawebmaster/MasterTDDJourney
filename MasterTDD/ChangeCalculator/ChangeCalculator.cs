namespace ChangeCalculator;

public class ChangeCalculator
{
    public static List<double> GetChange(double cost, double paid)
    {
        if (paid < cost)
        {
            throw new ArgumentException("Paid amount cannot be less than the cost.");
        }

        var change = Math.Round(paid - cost, 2); // Ensure precision to two decimal places

        if (change == 0)
        {
            return [0];
        }
        List<double> changeList = [];

        // Valid denominations sorted from largest to smallest
        double[] denominations = [100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01];

        foreach (var denomination in denominations)
        {
            while (change >= denomination - 0.001) // Tolerance for floating-point precision
            {
                changeList.Add(denomination);
                change -= denomination;
                change = Math.Round(change, 2); // Avoid floating-point accumulation errors
            }
        }

        return changeList;
    }
}