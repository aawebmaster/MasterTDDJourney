Console.WriteLine("Enter a position: ");

if (int.TryParse(Console.ReadLine(), out int position) && position >= 0)
{
    Console.WriteLine($"Fibonacci number for position {position} is {Fibonacci.Fibonacci.NthFibonacci(position)}.");
}
else
{
    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
}

