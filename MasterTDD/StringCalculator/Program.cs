Console.WriteLine(StringCalculator.StringCalculator.Add("1,2,3"));                       // Output: 6
Console.WriteLine(StringCalculator.StringCalculator.Add("1\n2,3"));                      // Output: 6
Console.WriteLine(StringCalculator.StringCalculator.Add(""));                            // Output: 0
Console.WriteLine(StringCalculator.StringCalculator.Add("5"));                           // Output: 5
Console.WriteLine(StringCalculator.StringCalculator.Add("//;\n1\n2;3"));                 // OutPut: 6 
Console.WriteLine(StringCalculator.StringCalculator.Add("1,\n"));                        // Exception => OutPut Invalid number format detected
//Console.WriteLine(StringCalculator.StringCalculator.Add("//;\n1;2;7;-4;-7;10"));       // Exception => OutPut Negatives not allowed: -3, -7
//Console.WriteLine(StringCalculator.StringCalculator.Add("//;\n1;2;7;-3;-7;-9"));       // Exception => OutPut Negatives not allowed: -3, -7, -9
//Console.WriteLine(StringCalculator.StringCalculator.Add("//;1;2;3"));                  // Exception => OutPut  Expected format: '//[delimiter]\n[numbers…]'

Console.Read();
