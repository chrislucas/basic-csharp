using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOComp
{
    class Program
    {

        public static void TestInput()
        {
            int n = int.Parse(Console.ReadLine());

            int[] values = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), a => Convert.ToInt32(a));

            foreach (var v in values)
            {
                Console.Write("{0}", v);
            }
        }


        public static void TestInterpolation()
        {

        }

        static void Main(string[] args)
        {

        }
    }
}
