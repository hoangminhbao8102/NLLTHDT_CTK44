using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab08_D_Bai3
{
    public class PhoneNumberValidator : IValidator
    {
        public bool Validate(object input)
        {
            var inputStr = input as string;
            if (inputStr == null) return false;

            var regex = new Regex(@"^0\d{9,10}$");
            return regex.IsMatch(inputStr);
        }
    }
}
