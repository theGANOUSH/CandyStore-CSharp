using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        static void getInput()
        {
            
            StreamReader fs = new StreamReader(@"Input.txt");

            string data;

            string[] nTests = fs.ReadLine().Split(' ');
            int nCandies = int.Parse(nTests[0]);
            double nCents = double.Parse(nTests[1]) *100;

            Console.WriteLine(nCandies + ", " + nCents);

            while ((data = fs.ReadLine()) != null)
            {

                string[] items = data.Split(' ');
                int Calories = int.Parse(items[0]);
                double cCost = double.Parse(items[1]) * 100;


                Console.WriteLine(Calories + ", " + cCost);


            }

            fs.Close();

        }

        static void Main(string[] args)
        {
            try
            {
                getInput();

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
