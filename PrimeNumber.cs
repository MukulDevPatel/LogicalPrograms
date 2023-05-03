using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void PrimeNum()
        {
            int a, n, mn, mx;
            Console.WriteLine("Minimum number:");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maximum number: ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime numbers of given range: {0} to {1}\n", mn, mx);

            for (n = mn; n <= mx; n++)
            {
                //Extract prime number to given range, a or flag
                //loop the iteration for sqrt(n) times
                a = 0;
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        a++;
                        break;
                    }
                }
                if (a == 0 && n != 1)
                {
                    Console.Write("{0} ", n);
                }
            }
        }
    }
}
