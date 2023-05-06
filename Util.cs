using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Util
    {
        public static double MonthlyPayment(double principal, int years, double interestRate)
        {
            int n = 12 * years;
            double r = interestRate / (12 * 100);
            double denominator = 1 - Math.Pow(1 + r, -n);
            double monthlyPayment = (principal * r) / denominator;
            return monthlyPayment;
        }
        public static void Calculate()
        {
            Console.Write("Enter Value of P: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter year value: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter interest rate: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            double monthlyPayment = Util.MonthlyPayment(principal, years, interestRate);

            Console.WriteLine("Monthly payment: {0}", monthlyPayment);
        }
    }
}
