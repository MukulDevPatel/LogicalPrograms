using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Util
    {
        public static void dayOfWeek(int m, int d, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            switch (d0)
            {
                case 0:
                    Console.Write("Sunday ");
                    break;
                case 1:
                    Console.Write("Monday ");
                    break;
                case 2:
                    Console.Write("Tuesday ");
                    break;
                case 3:
                    Console.Write("Wdnesday ");
                    break;
                case 4:
                    Console.Write("Thursday ");
                    break;
                case 5:
                    Console.WriteLine("Friday ");
                    break;
                case 6:
                    Console.Write("Saturday ");
                    break;
                default:
                    Console.Write("Enter a valid number");
                    return;
            }
            string dayOfWeek = " ";
            Console.WriteLine("{0}  {1}", d0, dayOfWeek);
        }
        public static void FindDay()
        {
            Console.Write("Enter a Date: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number of Month: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Util.dayOfWeek(m, d, y);
        }
    }
}
