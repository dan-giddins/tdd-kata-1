using System;
using System.Collections.Generic;
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

            List<string> delimiters = new List<string> { ",", "\n" };
            if (numbers.Count() > 1 && numbers.Substring(0, 2) == "//")
            {
                if (numbers[2] == '[')
                {
                    numbers = numbers.Substring(2);
                    while (numbers[0] == '[')
                    {
                        int endIndex = numbers.IndexOf(']');
                        delimiters.Add(numbers.Substring(1, endIndex - 1));
                        numbers = numbers.Substring(endIndex + 1);
                    }
                    numbers = numbers.Substring(1);
                }
                else
                {
                    delimiters.Add(numbers[2].ToString());
                    numbers = numbers.Substring(4);
                }
            }

            if (numbers == "")
            {
                return 0;
            }

            List<string> stringList = new List<string>() { numbers };
            foreach (string delimiter in delimiters)
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
                throw new Exception("negatives not allowed: " + String.Join(", ", negatives));
            }
            return result;
        }
    }
}
