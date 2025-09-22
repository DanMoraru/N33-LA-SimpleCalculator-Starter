using LibCalculatorEngine;
using System;
using System.Globalization;
using System.Threading;
using System.Web;



namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");

            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();      
                LibCalculatorEngine.CalculatorEngine calculatorEngine = new LibCalculatorEngine.CalculatorEngine();
                //double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                //double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());


                double firstNumber;
                while (true)
                {
                    Console.WriteLine(Properties.Constants.FirstNum);
                    string num1 = Console.ReadLine();

                    try
                    {
                        firstNumber = InputConverter.ConvertInputToNumeric(num1);
                        break;
                    } catch 
                    {
                        Console.WriteLine(Properties.Constants.InvalidNum+"\n");
                    }
                }

                double secondNumber;
                while(true)
                {
                    Console.WriteLine(Properties.Constants.SecondNum);
                    string num2 = Console.ReadLine();

                    try
                    {
                        secondNumber = InputConverter.ConvertInputToNumeric(num2);
                        break;

                    } catch
                    {
                        Console.WriteLine(Properties.Constants.InvalidNum + "\n");
                    }
                }

                // Check if the operation is valid
                string operation;
                while (true)
                {
                    Console.WriteLine(Properties.Constants.Operator);
                    string input = Console.ReadLine().ToLower();

                    if (input == "+" || input == "addition" || input == "-" || input == "subtraction" || input == "soustraction"
                        || input == "*" || input == "multiplication" || input == "/" || input == "division")
                    {
                        operation = input;
                        break;

                    } else
                    {
                        Console.WriteLine(Properties.Constants.InvalidInput);
                        Console.WriteLine("\n" + Properties.Constants.ValidOps + "\n");
                    }
                }

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                // Human readable format
                string operatorWord;
                string op = operation.ToLower();

                switch (op)
                {
                    case "+":
                    case "addition":
                        operatorWord = Properties.Constants.Add;
                        break;

                    case "-":
                    case "subtraction":
                    case "soustraction":
                        operatorWord = Properties.Constants.Sub;
                        break;

                    case "*":
                    case "multiplication":
                        operatorWord = Properties.Constants.Mult;
                        break;

                    case "/":
                    case "division":
                        operatorWord = Properties.Constants.Div;
                        break;

                    default:
                        operatorWord = "";
                        break;
                }

                Console.WriteLine($"\n{Properties.Constants.FinalVal1}{firstNumber} {operatorWord}{Properties.Constants.FinalVal2}" +
                    $"{secondNumber}{Properties.Constants.FinalVal3}{result:F2}");

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
