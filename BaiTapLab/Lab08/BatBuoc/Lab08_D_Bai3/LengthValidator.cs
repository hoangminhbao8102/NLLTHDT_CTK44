using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai3
{
    public class LengthValidator : IValidator
    {
        private int minLength;
        private int maxLength;

        public LengthValidator(int length)
        {
            this.minLength = length;
            this.maxLength = length;
        }

        public LengthValidator(int minLength, int maxLength)
        {
            this.minLength = minLength;
            this.maxLength = maxLength;
        }

        public bool Validate(object input)
        {
            var inputStr = input as string;
            if (inputStr == null) return false;

            return inputStr.Length >= minLength && inputStr.Length <= maxLength;
        }
    }
}
