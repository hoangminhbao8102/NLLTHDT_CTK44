using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai09
{
    public class Program
    {
        static int[] denominations = new int[] { 500, 1000, 2000, 5000, 10000, 20000 };

        static void Main(string[] args)
        {
            int amount;
            Console.Write("Enter the amount to change: ");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("All possible ways to change {0}:", amount);
            ChangeAmount(amount, new int[denominations.Length], 0);

            Console.ReadKey();
        }

        static void ChangeAmount(int amount, int[] count, int index)
        {
            if (amount == 0)
            {
                PrintCombination(count);
                return;
            }

            if (amount < 0 || index == denominations.Length)
            {
                return;
            }

            // Case: do not include the current denomination
            ChangeAmount(amount, count, index + 1);

            // Case: include the current denomination
            count[index]++;
            ChangeAmount(amount - denominations[index], count, index);
            count[index]--;
        }

        static void PrintCombination(int[] count)
        {
            for (int i = 0; i < denominations.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.Write("{0}x{1} ", count[i], denominations[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
