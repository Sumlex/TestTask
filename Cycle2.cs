using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

//Второй вариант 2 задания
public class Number
{
    public int Num { get; set; }
    public override string ToString()
    {
        return Num + ", ";
    }
    public void Result(ref List<Number> number,ref int count)
    {
        for (int i = 0; i < count; i++)
        try
        {
            Console.Write(number[i]);
        }
        catch
        {
            i = 0;
            count -= 5;
            Console.Write(number[i]);
        }

    }
}
public class Example
{
    public static void Main()
    {
        List<Number> number = new List<Number>();
        Number numb = new Number();

        Console.WriteLine("Введите необходимое количество объектов");
        int count = Convert.ToInt32(Console.ReadLine());

        number.Add(new Number() {Num = 2 });
        number.Add(new Number() {Num  = 4 });
        number.Add(new Number() {Num = 6 });
        number.Add(new Number() {Num = 8 });
        number.Add(new Number() {Num = 10 });

        Console.Write("Output: ");
        numb.Result(ref number,ref count);

    }
}