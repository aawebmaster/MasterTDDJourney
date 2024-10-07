Console.WriteLine("Enter a position:");

int.TryParse(Console.ReadLine(), out int position);
Console.WriteLine($"Fibonacci number for position {position} is {(Fibonacci.Fibonacci.NthFibonacci(position))}.");
