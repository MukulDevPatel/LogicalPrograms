using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class NewtonSqrt
    {
        static double Sqrt(double c)
        {
            if (c < 0) return 0; //Value of c cannot zero
            double t = c;
            double epsilon = 1e-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;
        }
        public static void NewtonMethod()
        {
            Console.Write("Enter value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Sqrt({c}) = {Sqrt(c)}");
        }

    }
}
