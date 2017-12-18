//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kata
//{
//    public class Kata
//    {
//        public static string AverageString(string str)
//        {
//            string[] words = str.Split(' ');
//            int total = 0;
//            for (var i = 0; i < words.Length; i++)
//            {
//                if (!System.Enum.IsDefined(typeof(EnumAverage), words[i]))
//                    return "n/a";
//                else
//                    foreach (string name in System.Enum.GetNames(typeof(EnumAverage)))
//                    {
//                        string strName = System.Enum.Parse(typeof(EnumAverage), name).ToString();
//                        if (words[i] == strName)
//                        {
//                            int strValue = (int) System.Enum.Parse(typeof(EnumAverage), strName);
//                            total = total + strValue;
//                        }
//                    }
//            }
//            int avg = (total / words.Length);
//            EnumAverage enumName = (EnumAverage)avg;
//            string avgName = enumName.ToString();
//            return avgName != "" || avg < 9 ? avgName : "n/a";
//        }

//        public static string AverageStringLinq(string str)
//        {
//            if (string.IsNullOrEmpty(str)) return "n/a";

//            var numbers = str.Split(' ').ToList();
//            if( numbers.Exists(s => !Enum.IsDefined(typeof(EnumAverage), s))) return "n/a";

//            return ((EnumAverage) (int) numbers.Select(s => (int) Enum.Parse(typeof(EnumAverage), s)).Average()).ToString();

//        }

//        private static bool IsValidInput(string input)
//        {
//            if (string.IsNullOrEmpty(input)) return false;

//            return true;
//        }

//        enum EnumAverage
//        {
//            zero,
//            one,
//            two,
//            three,
//            four,
//            five,
//            six,
//            seven,
//            eight,
//            nine,
//            ten
//        };
//    }
//}
