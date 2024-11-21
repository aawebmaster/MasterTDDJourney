

Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(100, 150)));        // Output: [50]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(224.99, 500)));     // Output: [100, 100, 50, 20, 5, 0.01]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(75, 100)));         // Output: [20, 5]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(19.99, 20)));       // Output: [0.01]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(1, 2)));            // Output: [1]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(1, 1)));            // Output: [0]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(0.25, 1)));         // Output: [0.50, 0.25]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(9.75, 10)));        // Output: [0.25]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(50, 100)));         // Output: [50]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(88.88, 100)));      // Output: [10, 1, 0.10, 0.01, 0.01]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(37.12, 50)));       // Output: [10, 2, 0.50, 0.25, 0.10, 0.01, 0.01]
Console.WriteLine(string.Join(", ", ChangeCalculator.ChangeCalculator.GetChange(37.12, 20)));      // Exception => OutPut  Paid amount cannot be less than the cost.