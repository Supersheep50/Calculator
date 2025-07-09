using CalculatorApp;
using System;



namespace CalculatorApp {
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator();

            while (true)
            {

                double a = GetValidNumber("Enter first number:");
                double b = GetValidNumber("enter second number:");
                Console.WriteLine("Choose operation: 1.Add 2.Subtract 3.Multiply 4.Divide");
                string choice = Console.ReadLine();

                double result = 0;

                switch (choice)
                {

                    case "1":
                        result = calc.Add(a, b);
                        break;
                    case "2":
                        result = calc.Subtract(a, b);
                        break;
                    case "3":
                        result = calc.Multiply(a, b);
                        break;
                    case "4":
                        result = calc.Divide(a, b);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");
            }

        }


        static double GetValidNumber(string prompt)
        {
            while (true)
            {

                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid number. Try again");
                }



            }
        }
    }
}


