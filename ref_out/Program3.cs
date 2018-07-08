using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out
{
    static class program3
    {
        static void Mian()
        {
            int a = 3;
            int c;
            Mohammad(ref a, out c);
            Console.WriteLine($"out Mohammad : a={a}, c={c}");
        }
        public static int Mohammad(ref int a, out int c)
        {
            a = 2;
            switch (a)
            {
                case 1:
                    {
                        c = 10;
                        break;
                    }
                case 2:
                    {
                        c = 20;
                        break;
                    }
                case 3:
                    {
                        c = 30;
                        break;
                    }
                default:
                    {
                        c = 100;
                        break;
                    }

            }
            Console.WriteLine($"in Mohammad : a={a}, c={c}");
            return (c);
        }
    }
}
