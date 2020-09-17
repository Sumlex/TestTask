using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

//первое задание
namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = Console.ReadLine();
            int i = repeat.Length;
            _ = repeat.ToCharArray(); //string to char[]
            int temp = 0;
            char ch; //number recorder
            Dictionary<char, int> numbers = new Dictionary<char, int>(i);

            for (int sch = 0; sch < i; sch++)
            {
                if (Char.IsDigit(repeat[sch])) //record number in new variable
                {
                    ch = repeat[sch];
                    for (int sch2 = 0; sch2 < i; sch2++)// how many iteration of number
                    {
                        if ((ch == repeat[sch2]))
                        {
                            temp++;
                        }
                    }
                    try
                    {
                        numbers.Add(ch, temp);
                    }
                    catch (ArgumentException)
                    {
                        temp = 0;
                        continue;
                    }
                    temp = 0;
                }
            }
            foreach (KeyValuePair<char, int> keyValue in numbers)
            {
                Console.WriteLine(keyValue.Key + " : " + keyValue.Value);
            }

        }
    }
}