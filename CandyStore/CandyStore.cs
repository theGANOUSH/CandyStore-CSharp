using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyStore
{
    class CandyStore
    {
        static int[] knapsack(int n, int m)
        {
            int[] nKnapsack = new int[m + 1];

            for (int i = 0; i < n; i++)
            {


            }
                return nKnapsack;
        }

        static void Main(string[] args)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"Input.txt");

                Console.WriteLine(lines[0]);

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
