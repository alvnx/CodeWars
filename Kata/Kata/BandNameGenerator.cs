using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class BandNameGenerator
    {
        static void Main(string[] args)
        {

        }

        public string GenerateBandName(string input)
        {
            var substring = input.Substring(1);
            var upper = input[0].ToString().ToUpper();
            if (input[0] == input[input.Length-1])
            {
                return upper + substring + substring;
            }
            return "The " + upper + substring;
        }
    }
}
