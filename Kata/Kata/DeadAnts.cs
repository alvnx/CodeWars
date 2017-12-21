using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class DeadAnts
    {
        public int DeadAntCount(string input)
        {
            if (input == null)
            {
                return 0;
            }
            var deadant = input.Replace("ant", string.Empty);

            return Math.Max(Math.Max(deadant.Count(x => x == 'a'), deadant.Count(x => x == 'n')), deadant.Count(x => x == 't'));
        }
    }
}
