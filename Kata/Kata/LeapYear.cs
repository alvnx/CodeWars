using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    public class LeapYear
    {
        public string IsLeapYear(int input)
        {
            string result;
            if (input % 400 == 0)
            {
                result = "an atypical leap";
            }
            else if (input % 100 == 0)
            {
                result = "an atypical common";
            }
            else if (input % 4 != 0)
            {
                result = "a typical common";
            }
            else
            {
                result = "a typical leap";
            }
            return input + " is " + result + " year";
        }
    }
}