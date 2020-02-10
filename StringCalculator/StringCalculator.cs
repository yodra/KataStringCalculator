using System;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        public StringCalculator()
        {
        }

        internal static int Add(string input)
        {
            var elementsSeparated = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            return input == "" ? 0 : elementsSeparated.Sum(int.Parse);
        }
    }
}
