using System;
namespace StringCalculator
{
    public class StringCalculator
    {
        public StringCalculator()
        {
        }

        internal static int Add(string input)
        {
            if (input.Length <= 1)
            {
                return input != "" ? int.Parse(input) : 0;
            }
            
            var inputArray = input.ToCharArray();
            var a = inputArray[0].ToString();
            var b = inputArray[^1].ToString();
            
            return int.Parse(a) + int.Parse(b);
        }
    }
}
