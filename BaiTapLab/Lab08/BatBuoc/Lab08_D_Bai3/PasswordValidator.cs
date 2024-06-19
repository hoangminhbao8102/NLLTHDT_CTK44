using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai3
{
    public class PasswordValidator : IValidator
    {
        private int minAlphabet;
        private int minDigit;
        private int minSymbol;

        public PasswordValidator(int minAlphabet, int minDigit, int minSymbol)
        {
            this.minAlphabet = minAlphabet;
            this.minDigit = minDigit;
            this.minSymbol = minSymbol;
        }

        public bool Validate(object input)
        {
            var inputStr = input as string;
            if (inputStr == null) return false;

            int countAlphabet = 0, countDigit = 0, countSymbol = 0;
            foreach (char ch in inputStr)
            {
                if (char.IsLetter(ch)) countAlphabet++;
                else if (char.IsDigit(ch)) countDigit++;
                else countSymbol++;
            }

            return countAlphabet >= minAlphabet && countDigit >= minDigit && countSymbol >= minSymbol;
        }
    }
}
