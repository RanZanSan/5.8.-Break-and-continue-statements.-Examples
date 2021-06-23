using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakAndContinueToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n <= 10)
            {
                if (n % 2 == 0)
                {
                    n++;
                    continue;
                }
                if (n == 7)
                {
                    break;
                }

                Console.WriteLine(n);
                n++;
            }
            Console.ReadKey();
        }
    }
}