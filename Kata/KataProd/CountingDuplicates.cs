﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataProd
{
    public class CountingDuplicates
    {
        public int Calculator(string input)
        {
            var count = 0;
            foreach (char c in input)
            {
                if (input.Count(x => x == c) > 1)
                {
                    count++;
                }
                input = input.Trim(c);
            }
            return count;
        }
    }
}
