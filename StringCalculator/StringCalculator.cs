using System;
namespace StringCalculator
{
    public class StringCalculator
    {
        public StringCalculator()
        {
        }

        internal static int Calculator(string input)
        {
            
            if (input.Length > 1)
            {
                char[] inputArray = input.ToCharArray();
                string a = inputArray[0].ToString();
                string b = inputArray[inputArray.Length - 1].ToString();
                return int.Parse(a) + int.Parse(b);
            }

            if (input != "")
            {
                return int.Parse(input);
            }

            return 0; 
        }
    }
}
