using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class CountingDuplicates
    {
        public int Calculator(string input)
        {
            input = input.ToLower();

            var count = 0;
            foreach (char c in input)
            {
                if (input.Count(x => x == c) > 1)
                {
                    count++;
                }
                input = input.Replace(c.ToString(),"");
            }
            return count;
        }
    }
}
