using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static int ConvertInputToNumeric(string argTextInput)
        {
            return int.Parse(argTextInput);
        }
    }
}
