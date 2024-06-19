using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai3
{
    public class RangeValidator : IValidator
    {
        private double minValue;
        private double maxValue;

        public RangeValidator(double min, double max)
        {
            minValue = min;
            maxValue = max;
        }

        public bool Validate(object input)
        {
            if (input is double inputValue)
            {
                return inputValue >= minValue && inputValue <= maxValue;
            }
            return false;
        }
    }
}
