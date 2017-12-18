using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class DeadAnts
    {
        public int DeadAntsCount(string input)
        {
            //var antBodies = input.Replace("ant", "/");
            //Console.WriteLine(antBodies);
            //int antCount = antBodies.Split('/').Length - 1;
            //return antCount;
            var antBodies = input.Replace("ant", "");
            if (!antBodies.Contains("ant"))
            {
                Console.WriteLine(antBodies);
                return 0;
            }else if (antBodies.Contains("ant"))
            {
                int count = antBodies.Split(' ').Length - 1;
                return count;
            }else if (antBodies.Trim(' ').Contains("ant")){
                string bodyCount = antBodies.Replace(" ", "");
                Console.WriteLine(bodyCount);
            }
            Console.WriteLine(antBodies);
            //if (input == "ant anantt aantnt")
            //{
            //    return 2;
            //}
            //if (input == "ant ant .... a nt")
            //{
            //    return 1;
            //}
            //if (input == "ant ant ant ant")
            //{
            //    return 0;
            //}
            return 9999;
            
        }
    }
}
