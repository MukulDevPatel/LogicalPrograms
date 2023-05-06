using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        public static void GetChange()
        {
            int[] notes = { 2000, 500, 100, 50, 10, 5, 2, 1 }; // available notes
            Console.Write("Enter the change in Rs: ");
            int change = int.Parse(Console.ReadLine());
            int[] count = new int[notes.Length]; // to store count of each note
            int totalNotes = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                //Count note value in different notes which available
                if (change >= notes[i])
                {
                    count[i] = change / notes[i];
                    totalNotes += count[i];
                    change %= notes[i];
                }
            }
            Console.WriteLine("Minimum number of notes needed: " + totalNotes);

            //Print available different notes
            Console.Write("Notes to be given: ");
            for (int i = 0; i < notes.Length; i++) 
            {
                for (int j = 0; j < count[i]; j++)
                {
                    Console.Write(notes[i] + " " + "\n");
                }
            }
        }
    }
}
