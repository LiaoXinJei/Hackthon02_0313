using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rate
{
    public class Calculate
    {
        public static decimal CaculateRate(decimal money)
        {
            var list = RateList.CreateDictionary();
            var tmp = list.Where(x => x.Value.StartRange < money );
            int key = -1;
            foreach (var i in tmp)
            {
                key++;
            }
            decimal sum = 0;
            if (key != 0)
            {
                for (var i = key; i > 0; i--)
                {
                    sum += (list[i-1].EndRange-list[i-1].StartRange) * list[i-1].rate;
                }
            }
            sum += (money - list[key].StartRange) * list[key].rate;
            return sum;
        }
    }
}
