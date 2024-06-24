using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai2
{
    public class StringManipulator
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }

            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                stack.Push(c);
            }

            StringBuilder reversed = new StringBuilder();
            while (stack.Count > 0)
            {
                reversed.Append(stack.Pop());
            }

            return reversed.ToString();
        }
    }
}
