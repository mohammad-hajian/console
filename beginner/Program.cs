using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            //dars 1 ##############################################################################

            //Console.WriteLine("hello world!");
            //Console.ReadKey();
            //dars 2 ##############################################################################
            //int a; long b = 966;
            //a = (int)b;
            //dars 3 & 4 & 5 ######################################################################
            //bool wqw = true;//false
            //int i = 1, q;
            //i++;
            //++i;
            //q = ++i;
            //q = i++;

            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);

            //try
            //{

            //}
            //catch (Exception p)
            //{
            //    Console.WriteLine(p.Message);
            //}

            //switch (i)
            //{
            //    case 1: Console.WriteLine("one");
            //        break;
            //    case 2: Console.WriteLine("two");
            //        break;
            //    case 3: Console.WriteLine("three");
            //        break;
            //    case 4: 
            //    case 5: 
            //    case 6: 
            //    case 7: Console.WriteLine("four");
            //        break;
            //    default:
            //        Console.WriteLine("d");
            //        break;
            //}

            //dars 6 ##############################################################################
            int[] intNumber = new int[] {50,0,0,6,80 };

            for (int i = 0; i < intNumber.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {intNumber[i]}");
            }
            for (int i = intNumber.Length-1; i >= 0; i--)
            {
                intNumber[i]++;
                Console.WriteLine($"array[{i}] = {intNumber[i]}");
            }
            foreach (var item in intNumber)
            {
                Console.WriteLine($"array = {item}");
            }
        }
    }
}
