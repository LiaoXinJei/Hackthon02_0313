using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberJudgement
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 1; i <= 100; i++)
            {
                if (i % 15 != 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
