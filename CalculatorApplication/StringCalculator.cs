using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorApplication
{
   public class StringCalculator
    {
        List<string> delimeters = new List<string>
                             {
                                 ",", "\n"

                             };
        public int Add(string numbers)
        {
            List<int> ValidNumber;
            
            if (string.IsNullOrEmpty(numbers))
                return 0;
            else
                numbers= RemoveCustomDelimiter(numbers);
            ValidNumber = CheckForDelimeters(numbers);
            return ValidNumber.Sum();
        }

        public List<int> CheckForDelimeters(string numbers)
        {
            List<int> validIntegers = new List<int>();
            
            string[] numbs = numbers.Split(delimeters.ToArray(), StringSplitOptions.None);
            for (int i = 0; i < numbs.Length; i++)
            {
                int value = 0;
                if (int.TryParse(numbs[i], out value)) validIntegers.Add(value);
            }

            return validIntegers;

        }

        public string RemoveCustomDelimiter(string numbers)
        {
            string _delimeter;
            var arrayStartIndex = Regex.Match(numbers, "\\d").Index;
            _delimeter = numbers.Substring(0, arrayStartIndex);
            foreach (char item in _delimeter)
            {
                delimeters.Add(item.ToString());
            }
           
            return numbers;
        }

        

    }
}
