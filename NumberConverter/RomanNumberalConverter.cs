using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverter
{
    public class RomanNumeralConverter
    {
        private readonly Dictionary<string, int> romanValues = new Dictionary<string, int>()
        {
            {"M", 1000},
            {"D", 500},
            {"C", 100},
            {"L", 50},
            {"X", 10},
            {"V", 5},
            {"I", 1},
        }; 
        public virtual string ConvertToLetter(int number)
        {
            if (number < 1 || number > 3000) throw new IndexOutOfRangeException("The number supplied is out of the expected range (1 - 3000).");
            var result = new StringBuilder();
            foreach (var romanValue in romanValues)
            {
                while (number >= romanValue.Value)
                {
                    result.Append(romanValue.Key);
                    number -= romanValue.Value;
                }
            }
            return result.ToString();
        }

        public int ConvertToValue(string s)
        {
            var result = 0;
            var found = romanValues.TryGetValue(s, out result);
            if (found)
            {
                return result;
            }
            throw new IndexOutOfRangeException();
        }
    }
}
