using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai3
{
    public class NotEmptyValidator : IValidator
    {
        public bool Validate(object input)
        {
            var inputStr = input as string;
            return !string.IsNullOrWhiteSpace(inputStr);
        }
    }
}
