using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一段字串來判斷是否為回文：");
            var input = Console.ReadLine().ToCharArray();
            var get = Test.PalindromeTest(input);
            Console.WriteLine(get);
            Console.ReadLine();
        }
    }

    public static class Test
    {
        public static string PalindromeTest(char[] input)
        {
            var get=string.Empty;
            for (var i = 0; i < input.Length; i++)
            {
                if (i == input.Length - i - 1)
                    return get="你輸入的是回文";
                else
                {
                    if (input[i] != input[input.Length - i - 1])
                    {
                        return get = "你輸入的不是回文";
                    }
                }
            }
            return get;
        }
    }
}
