using System;
using System.Threading;

namespace Lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Rakib");
            int a = 100;
            int b = 5;
            int c = a + b;
            int d = a / b;
            Console.WriteLine("the number of sum is :" + c);
            Console.WriteLine("the result of division is:" + d);
            int x = 5;
            int y = 8;
            int z = 6;
            Console.WriteLine("the solution is:" + (-x + y * z));
            int e = 55;
            int f = 9;
            Console.WriteLine("the solution is:" + (e+f)%f);
            int g = 20;
            int h = -3;
            Console.WriteLine("the solution is:" + (g+h*x/y));
            int i = 15;
            int j = 3;
            int k = 2;
            Console.WriteLine("the solution is:" + (x + i / j * k - y % j));
            Console.WriteLine("the result of multiplication is " + (a * b));
            Console.WriteLine("the result of msubstitution is " + (a - b));
            Console.WriteLine("the result of remainder is " + (a % b));
            double l = 25.5;
            double m = 3.5;
            double  n = 40.5;
            double o = 4.5;
            Console.WriteLine("the solution is:" + ((l * m - m * m) / (n - o)));
            double width = 5.5;
            double height = 8.5;
            Console.WriteLine("the area is :" + (width * height));
            Console.WriteLine("the perimeter is :" + (2*(width + height)));

        }
    }
}
