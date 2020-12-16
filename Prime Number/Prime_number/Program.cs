using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max,flag=0;
            Console.WriteLine("Enter min and max : ");
            min = int.Parse(Console.ReadLine());
            max = int.Parse(Console.ReadLine());
            while(min<=max)
            {
                flag = 0;
                for(int i=2;i<=(min/2);i++)
                {
                    if(min%i==0)
                    {
                        flag = 1;
                    }
                }
                if(min<2)
                {
                    min++;
                    continue;
                }
                if(flag==0)
                {
                    Console.WriteLine(min);
                }
                min++;
            }
        }
    }
}
