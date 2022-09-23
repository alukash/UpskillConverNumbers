using System;
using System.Collections.Generic;

namespace ConverNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = args[0];
            Console.WriteLine("Number to convert: " + number);

            string targetBase = args[1];
            Console.WriteLine("Base: " + targetBase);

            string s = ConvertNumber(number, targetBase);
            Console.WriteLine("Result: " + s);

            Console.WriteLine();
            Console.Write("Press any key to close the app...");
            Console.ReadKey();

        }

        private static string ConvertNumber(string number, string targetBase)
        {
            int num = int.Parse(number);
            int tBase = int.Parse(targetBase);
            int remainder;
            List<string> remainders = new List<string>();

            do
            {
                remainder = num % tBase;
                num = num / tBase;
                remainders.Add((remainder.ToString()));
            }
            while (num > 0);

            string strTemp = string.Empty;
            remainders.Reverse();
            remainders.ForEach(s => strTemp += s);
            return strTemp;
        }
    }
}
