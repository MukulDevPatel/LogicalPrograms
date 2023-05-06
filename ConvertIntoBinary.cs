using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ConvertIntoBinary
    {
        public static void ToBinary()
        {
            int dec;
            int n;
            string binary = "";
            Console.Write("Enter a Decimal value: ");
            dec = Convert.ToInt32(Console.ReadLine());
            
            //Convert decimal number in binary (0 or 1) language
            while (dec >= 1)
            {
                n = dec / 2;
                binary += (dec % 2).ToString();
                dec = n;
            }
            string binValue = "";

            //Decresing 
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                binValue = binValue + binary[i];
            }
            Console.WriteLine("Binary: {0}", binValue);
        }

    }
}
