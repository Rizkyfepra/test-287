using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter first number (or type 'exit' to quit):");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "exit") break;

            Console.WriteLine("Enter second number:");
            string input2 = Console.ReadLine();

            Console.WriteLine("Enter operation (+, -, *, /):");
            char operation = Console.ReadLine()[0];

            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Error: Division by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
        }
    }
}