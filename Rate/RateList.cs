using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rate
{
    public class RateList
    {
        public int StartRange { get; set; }
        public int EndRange { get; set; }
        public decimal rate { get; set; }

        public static Dictionary<int,RateList> CreateDictionary()
        {
            var Rate = new RateList();
            var Dictionary = new Dictionary<int,RateList>();
            Dictionary.Add(0,new RateList { StartRange = 0, EndRange = 540000, rate = 0.05m, });
            Dictionary.Add(1,new RateList {  StartRange = 540000, EndRange = 1210000, rate = 0.12m });
            Dictionary.Add(2,new RateList {  StartRange = 1210000, EndRange = 2420000, rate = 0.2m });
            Dictionary.Add(3,new RateList {  StartRange = 2420000, EndRange = 4530000, rate = 0.3m });
            Dictionary.Add(4,new RateList {  StartRange = 4530000, EndRange = 10310000, rate = 0.4m });
            Dictionary.Add(5,new RateList { StartRange = 10310000, EndRange = 2147483647, rate = 0.5m });
            return Dictionary;
        }
    }
    
}
