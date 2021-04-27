using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("num1 = 15.2 , mum2 = 3.2");

            var plus = new Plus(15.2, 3.2);
            plus.Show();
            var result = plus.Execute();
            Console.WriteLine($"Result : {result}");

            var minus = new Minus(15.2, 3.2);
            minus.Show();
            var result1 = minus.Execute();
            Console.WriteLine($"Result : {result1}");

            var multiplied = new Multiplied(15.2, 3.2);
            multiplied.Show();
            var result2 = multiplied.Execute();
            Console.WriteLine($"Result : {result2}");

            var divide = new Divide(15.2, 3.2);
            divide.Show();
            var result3 = divide.Execute();
            Console.WriteLine($"Result : {result3}");
        }
    }
}
