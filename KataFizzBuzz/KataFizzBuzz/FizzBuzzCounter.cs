using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFizzBuzz
{
    public class FizzBuzzCounter : IFizzBuzzCounter
    {
        public List<string> Counter(int input)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= input; i++)
            {
                result.Add(Translate(i));
            }
            return result;
        }

        public string Translate(int input)
        {
            string result = string.Empty;
            if (input % 3 == 0 && input % 5 == 0) result = "FizzBuzz";
            else if (input % 3 == 0) result = "Fizz";
            else if (input % 5 == 0) result = "Buzz";
            else result = input.ToString();
            return result;
        }

    }
}
