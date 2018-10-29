using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatString
{
    class Program
    {
        
        /**
         https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/tokens/interpolated
         */
        static void Main(string[] args)
        {
            //string name = "Chris Lucas";
            // visual studio 2013 nao suporta string interpolation
            //Console.Write(String.Format("{0}", name));

            /**
                Formatacao numerica
             * https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/formatting-numeric-results-table
             */

            // um numero decimal com cinco digitos (com 0 a esquerda)
            Console.WriteLine(String.Format("{0:D5}", 2555));
            Console.WriteLine(String.Format("{0:F3}", 2.55));
            Console.WriteLine(String.Format("{0:f14}", Math.PI));
            // hexadecimal
            Console.WriteLine(String.Format("{0:X2}", 15));


            Console.WriteLine(String.Format("{0:#.###}", 2.12));

           
            Console.WriteLine(String.Format("{0:0.00#}", 2.12));

            Console.WriteLine(String.Format("{0:#.#%}", .152));


        }
    }
}
