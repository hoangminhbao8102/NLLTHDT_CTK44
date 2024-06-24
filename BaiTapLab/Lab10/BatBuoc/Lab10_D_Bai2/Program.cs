using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string original = "hello";
                string reversed = StringManipulator.ReverseString(original);
                Console.WriteLine($"Original: {original}");
                Console.WriteLine($"Reversed: {reversed}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
