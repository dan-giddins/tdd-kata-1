using System;
using System.Collections.Generic;
using System.Linq;

namespace tdd_kata_1
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            List<char> delimiters = new List<char> { ',', '\n' };
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

            int result = 0;
            List<int> negatives = new List<int>();
            bool hasNegatives = false;
            foreach (string s in stringList)
            {
                int i = Int32.Parse(s);
                if (i < 0)
                {
                    negatives.Add(i);
                    hasNegatives = true;
                }
                else if (!hasNegatives && !(i > 1000))
                {
                    result += i;
                }
            }
            if (hasNegatives)
            {
                throw new Exception("negatives not allowed: " + String.Join(", ", negatives.Count));
            }
            return result;
        }
    }
}
