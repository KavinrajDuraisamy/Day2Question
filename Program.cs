using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("a value = " + a);
            Console.WriteLine("b value = " + b);
            Console.WriteLine("a+b= " + c);
            Console.WriteLine( a+" "+b);
            Console.WriteLine($"a={a} \nb={b} \na+b={c}");
            */

            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            string d = Console.ReadLine();
            Console.WriteLine($"a={a} \nb={b} \nc={c} \nd={d}");
            Console.WriteLine("edited from newtry");
        }
    }
}
