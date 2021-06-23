using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 10; n++)
            {
                if (n % 2 == 0)
                {
                    continue;
                }
                if (n == 7)
                {
                    break;
                }

                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}