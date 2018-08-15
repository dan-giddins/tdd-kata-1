using System;
using System.Linq;

namespace tdd_kata_1
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }
            string[] strings = numbers.Split(',');
            int result = 0;
            foreach (string s in strings)
            {
                result += Int32.Parse(s);
            }
            return result;
        }
    }
}
