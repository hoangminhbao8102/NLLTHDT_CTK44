using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai2
{
    public class PermutationGenerator
    {
        private string _letters;

        public PermutationGenerator(string letters)
        {
            // Ensure the letters are sorted to start with the smallest lexicographical permutation
            char[] charArray = letters.ToCharArray();
            Array.Sort(charArray);
            _letters = new string(charArray);
        }

        public List<string> GeneratePermutations()
        {
            var result = new List<string>();
            char[] array = _letters.ToCharArray();

            do
            {
                result.Add(new string(array));
            } while (NextPermutation(array));

            return result;
        }

        private bool NextPermutation(char[] array)
        {
            int k = array.Length - 2;
            while (k >= 0 && array[k] >= array[k + 1])
            {
                k--;
            }
            if (k < 0) return false;

            int l = array.Length - 1;
            while (array[k] >= array[l])
            {
                l--;
            }

            Swap(ref array[k], ref array[l]);
            Array.Reverse(array, k + 1, array.Length - k - 1);
            return true;
        }

        private void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
    }
}
