using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCalculatorEngine
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;
            string op = argOperation.ToLower();

            switch (op)
            {
                case "+":
                case "addition":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "-":
                case "subtraction":
                case "soustraction":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "*":
                case "multiplication":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "/":
                case "division":
                    if (argSecondNumber == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero");
                    }

                    result = argFirstNumber / argSecondNumber;
                    break;

                default:
                    throw new ArgumentException("Invalid operation entered");


            }

            return result;
        }
    }
}
