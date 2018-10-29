using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{

    public static class ParseInt
    {
        public static bool IsInt(this string data)
        {
            int output;
            return int.TryParse(data, out output);
        }

        public static int ToInt(this string data)
        {
            if (IsInt(data))
                return int.Parse(data);
            else
                throw new Exception("Not A Number");
        }

        public static int[] GetVInt(this string data, char [] delimiter)
        {
            string [] splitted = data.Split(delimiter);
            int[] values = new int[splitted.Length];
            for (int i = 0; i < splitted.Length; i++)
            {
                values[i] = splitted[i].ToInt();
            }
            return values;
        }
    }


    public static class ParseULong
    {
        public static ulong ToULong(this string data) 
        {
            return ulong.Parse(data);
        }

        public static ulong[] GetVULong(this string data, char[] delimiter)
        {
            string [] splitted = data.Split(delimiter);
            ulong[] values = new ulong[splitted.Length];
            for (int i = 0; i < splitted.Length; i++)
            {
                values[i] = splitted[i].ToULong();
            }
            return values;
        }
    }


    class Program
    {

        public static void TestInt()
        {
            int data = Console.ReadLine().ToInt();
            Console.WriteLine(data);

            int[] values = Console.ReadLine().GetVInt(new char[] { ' ' });

            foreach (var v in values)
            {
                Console.WriteLine(v);
            }
        }

        public static void TestULong()
        {
            ulong data = Console.ReadLine().ToULong();
            Console.WriteLine(data);
        }


        static void Main(string[] args)
        {
            TestULong();
        }
    }
}
