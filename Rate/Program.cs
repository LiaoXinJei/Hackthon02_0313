using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入年收入，計算出應繳納稅率");
            var get = Console.ReadLine();
            decimal tmp = 0;
            decimal Rate;
            Console.WriteLine(Calculate.CaculateRate(Convert.ToDecimal(get)));
            //if (decimal.TryParse(get, out tmp))
            //{
            //    Rate = Calculate.CaculateRate(tmp);
            //    Console.WriteLine(Rate);
            //}
            Console.ReadLine();
        }

        

    }
}
