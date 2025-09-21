using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "addition")
            {
                result = argFirstNumber + argSecondNumber;
            }
            else if (argOperation == "-" || argOperation.ToLower() == "subtraction")
            {
                result = argFirstNumber - argSecondNumber;
            }
            else if (argOperation == "*" || argOperation.ToLower() == "multiplication")
            {
                result = argFirstNumber * argSecondNumber;
            }
            else if (argOperation == "/" ||  argOperation.ToLower() == "division")
            {
                result = argFirstNumber / argSecondNumber;

                if (argSecondNumber == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }
            }
            else
            {
                throw new ArgumentException("Invalid operation entered");
            }

                return result;
        }
    }
}
