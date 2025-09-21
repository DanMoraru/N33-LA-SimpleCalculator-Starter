using System;
using System.Web;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                //double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                //double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());


                double firstNumber;
                while (true)
                {
                    Console.WriteLine("Enter the first number: ");
                    string num1 = Console.ReadLine();

                    try
                    {
                        firstNumber = InputConverter.ConvertInputToNumeric(num1);
                        break;
                    } catch
                    {
                        Console.WriteLine("Invalid input. Enter a number\n");
                    }
                }

                double secondNumber;
                while(true)
                {
                    Console.WriteLine("Enter the second number: ");
                    string num2 = Console.ReadLine();

                    try
                    {
                        secondNumber = InputConverter.ConvertInputToNumeric(num2);
                        break;

                    } catch
                    {
                        Console.WriteLine("Invalid input. Enter a number\n");
                    }
                }

                // Check if the operation is valid
                string operation;
                while (true)
                {
                    Console.WriteLine("Enter the operator: ");
                    string input = Console.ReadLine().ToLower();

                    if (input == "+" || input == "addition" || input == "-" || input == "subtraction"
                        || input == "*" || input == "multiplication" || input == "/" || input == "division")
                    {
                        operation = input;
                        break;

                    } else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("\nValid inputs include: \n" +
                            "'+', '-', '*', '/', 'addition', 'subtraction', 'multiplication', 'division'\n");
                    }
                }

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                // Human readable format
                string operatorWord;
                string op = operation.ToLower();

                switch (op)
                {
                    case "+":
                    case "add":
                        operatorWord = "plus";
                        break;

                    case "-":
                    case "subtract":
                        operatorWord = "minus";
                        break;

                    case "*":
                    case "multiply":
                        operatorWord = "times";
                        break;

                    case "/":
                    case "divide":
                        operatorWord = "divided by";
                        break;

                    default:
                        operatorWord = "";
                        break;
                }

                Console.WriteLine($"\nThe value {firstNumber} {operatorWord} the value " +
                    $"{secondNumber} is equal to {result:F2}");

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
