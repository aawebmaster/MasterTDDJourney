int year;
Console.WriteLine("Enter a year:");

if (int.TryParse(Console.ReadLine(), out year))
{
    Console.WriteLine($"Year {year} is {(LeapYear.LeapYear.IsLeapYear(year) ? "a" : "not a")} leap year.");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}
