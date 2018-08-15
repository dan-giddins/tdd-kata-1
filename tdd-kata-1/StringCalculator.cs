using System;
using System.Collections.Generic;
using System.Linq;

namespace tdd_kata_1
{
    public class StringCalculator
    {
        private List<char> delimiters;
        int result;

        public int Add(string numbers)
        {
            delimiters = new List<char> { ',', '\n' };
            if (numbers.Length > 3
                && numbers.Substring(0, 2) == "//"
                && numbers[3] == '\n')
            {
                delimiters.Add(numbers[2]);
                numbers = numbers.Substring(4);
            }

            if (numbers == "")
            {
                return 0;
            }

            List<string> stringList = new List<string>() { numbers };
            foreach (char delimiter in delimiters)
            {
                List<string> tempStringList = new List<string>();
                foreach (string s in stringList)
                {
                    tempStringList.AddRange(s.Split(delimiter));
                }
                stringList = tempStringList;
            }

            result = 0;
            foreach (string s in stringList)
            {
                int i = Int32.Parse(s);
                try
                {
                    if (i < 0)
                    {
                        throw new Exception("negatives not allowed: " + i);
                    }
                    if (!(i > 1000))
                    {
                        result += i;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return result;
        }
    }
}
