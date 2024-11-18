using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator{
public class StringCalculator
{
    public static int Add(string numbers)
    {
        // Step 1: Handle empty input
        if (string.IsNullOrEmpty(numbers))
            return 0;

        // Step 2: Check for custom delimiter
        string delimiter = ","; // Default delimiter is a comma
        if (numbers.StartsWith("//"))
        {
            // Find the index of the first newline character after "//"
            int delimiterEndIndex = numbers.IndexOf('\n');

            // Ensure newline character was found, otherwise throw an exception
            if (delimiterEndIndex == -1)
            {
                throw new ArgumentException("Incorrect format. Expected format: '//[delimiter]\\n[numbers…]'");
            }
            
            // Extract the delimiter from between "//" and "\n"
            delimiter = numbers.Substring(2, delimiterEndIndex - 2);
            
            // Adjust the `numbers` string to remove the first line (delimiter declaration)
            numbers = numbers.Substring(delimiterEndIndex + 1);
        }

        // Step 3: Split numbers by delimiters (default is comma and newline)
        // Use both the extracted/custom delimiter and newline as valid delimiters
        string[] numArray = numbers.Split(new[] { delimiter, "\n" }, StringSplitOptions.None);

        // Step 4: Validate numbers, handle negatives, and accumulate the sum
        List<int> negatives = new List<int>();
        int sum = 0;

        foreach (string numStr in numArray)
        {
            if (string.IsNullOrWhiteSpace(numStr))
            {
                // Throw an exception if there's an invalid format, such as an empty entry between delimiters
                throw new ArgumentException($"Invalid number format detected ");
            }
            if (int.TryParse(numStr, out int number)) // Attempt to parse each item as an integer
            {
                if (number < 0)
                {
                    // Add negative numbers to the list for later exception handling
                    negatives.Add(number);
                }
                else
                {
                    // Accumulate the sum of non-negative numbers
                    sum += number;
                }
            }else
            {
                throw new ArgumentException($"Please check the format, invalid number: {numStr}");
            }
        }

        // Step 5: Throw exception if there are any negative numbers
        if (negatives.Any())
        {
            throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negatives)}");
        }

        return sum;
    }
}



}

