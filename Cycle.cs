using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

//Первый вариант второго задания
//Думал просто мало ли не так сделал
namespace TestTask
{
    public class Cycler
    {
        public int[] number = new int[6];

        public Cycler() { }
        public Cycler(ref List<int> numbers)
        {
            numbers.CopyTo(number);
        }
        public void Result(ref int count)
        {
            for (int i = 0; i < count; i++)
            {
                try
                {
                    Console.Write(number[i] + ", ");
                }
                catch
                {
                    i = 0;
                    count -= 4;
                    Console.Write(number[i] + ", ");
                }
            }

        }
    }
    class Cycle
    {
        static void Main()
        {
            int count;
            Console.WriteLine("Введите количество выводимых элементов");
            count = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int> { 2, 4, 6, 8, 10, 12 };
            Cycler cycler = new Cycler(ref numbers);

            cycler.Result(ref count);
        }
    }

}
