using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Binary
    {
        public static void ToBinary()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            string binaryStr = Convert.ToString(num, 2);
            Console.WriteLine("Binary representation: {0}", binaryStr);

            // Pad the binary string with leading zeros if necessary
            binaryStr = binaryStr.PadLeft(8, '0');

            // Swap the nibbles
            string swappedStr = binaryStr.Substring(4) + binaryStr.Substring(0, 4);
            Console.WriteLine("Swapped nibbles: {0}", swappedStr);

            int swappedNum = Convert.ToInt32(swappedStr, 2);
            Console.WriteLine("Decimal representation of swapped nibbles: {0}", swappedNum);

            // Check if the resulting number is a power of 2
            bool isPowerOf2 = (swappedNum & (swappedNum - 1)) == 0;
            Console.WriteLine("Is the swapped number a power of 2 = {0}", isPowerOf2);
        }   

    }
}
