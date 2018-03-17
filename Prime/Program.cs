using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("101 ~ 200 之間的質數: ");
            for(var i = 101; i<=200; i++)
            {
                 var count = 0;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                        count++;
                    if (count == i - 2)
                        Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
