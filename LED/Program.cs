using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LED
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串數字");
            var input = Console.ReadLine().ToCharArray();

            string line1 = string.Empty, line2 = string.Empty, line3 = string.Empty;
            for (var i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0':
                        line1 += "|￣|";
                        line2 += "|　|";
                        line3 += " ￣ ";
                        break;

                    case '1':
                        line1 += " 　|";
                        line2 += " 　|";
                        line3 += " 　 ";
                        break;

                    case '2':
                        line1 += " ￣|";
                        line2 += "|￣ ";
                        line3 += " ￣ ";
                        break;

                    case '3':
                        line1 += " ￣|";
                        line2 += " ￣|";
                        line3 += " ￣ ";
                        break;

                    case '4':
                        line1 += "|　|";
                        line2 += " ￣|";
                        line3 += " 　 ";
                        break;

                    case '5':
                        line1 += "|￣ ";
                        line2 += " ￣|";
                        line3 += " ￣ ";
                        break;

                    case '6':
                        line1 += "|￣ ";
                        line2 += "|￣|";
                        line3 += " ￣ ";
                        break;

                    case '7':
                        line1 += " ￣|";
                        line2 += " 　|";
                        line3 += " 　 ";
                        break;

                    case '8':
                        line1 += "|￣|";
                        line2 += "|￣|";
                        line3 += " ￣ ";
                        break;

                    case '9':
                        line1 += "|￣|";
                        line2 += " ￣|";
                        line3 += " ￣ ";
                        break;

                    default:
                        Console.WriteLine("輸入錯誤");
                        break;
                }
            }
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.ReadLine();
        }
    }
}
