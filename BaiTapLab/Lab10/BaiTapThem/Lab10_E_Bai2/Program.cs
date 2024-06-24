using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string letters = "abcdefgh";
            var generator = new PermutationGenerator(letters);
            var permutations = generator.GeneratePermutations();

            foreach (var perm in permutations)
            {
                Console.WriteLine(perm);
            }

            Console.ReadKey();
        }
    }
}
