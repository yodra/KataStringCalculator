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

            var elementsSeparated = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var result = 0;
            
            foreach (var element in elementsSeparated)
            {
                result += int.Parse(element);
            }
            
            return result;
        }
    }
}
