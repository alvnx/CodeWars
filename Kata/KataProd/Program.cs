using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataProd
{
    public class BandNameGenerator
    {
        static void Main(string[] args)
        {
        }

        public string GenerateBandName(string input)
        {
            var length = input.Length;
            if (input.Substring(0, 1) == input.Substring(length - 1, 1))
            {
                return input[0].ToString().ToUpper() + input.Substring(1) + input.Substring(1);
            }
            return "The " + input[0].ToString().ToUpper() + input.Substring(1);
        }
    }
}
