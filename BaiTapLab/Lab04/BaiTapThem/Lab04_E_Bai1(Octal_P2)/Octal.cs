using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai1_Octal_P2_
{
    public class Octal
    {
        private double _number;

        // Conversion from Octal to int (explicit).
        public static explicit operator int(Octal x)
        {
            return Convert.ToInt32(x._number.ToString(), 8);
        }

        // Conversion from Octal to double (explicit).
        public static explicit operator double(Octal x)
        {
            return x._number;
        }

        // Conversion from double to Octal (explicit).
        public static explicit operator Octal(double x)
        {
            return new Octal(x);
        }

        public Octal(double conSo)
        {
            _number = Math.Round(conSo, 3); // Round to ensure three decimal places precision
        }

        // Overloading the + operator.
        public static Octal operator +(Octal x, Octal y)
        {
            return new Octal(x._number + y._number);
        }

        // Overloading the - operator.
        public static Octal operator -(Octal x, Octal y)
        {
            return new Octal(x._number - y._number);
        }

        // Overloading the * operator.
        public static Octal operator *(Octal x, Octal y)
        {
            return new Octal(x._number * y._number);
        }

        // Overloading the / operator.
        public static Octal operator /(Octal x, Octal y)
        {
            if (y._number == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return new Octal(x._number / y._number);
        }

        // Modulo operator
        public static Octal operator %(Octal x, Octal y)
        {
            return new Octal(x._number % y._number);
        }

        // Decrement operator
        public static Octal operator --(Octal x)
        {
            return new Octal(x._number - 1);
        }

        // Increment operator
        public static Octal operator ++(Octal x)
        {
            return new Octal(x._number + 1);
        }

        // Comparison operators
        public static bool operator <(Octal x, Octal y)
        {
            return x._number <= y._number;
        }

        public static bool operator <=(Octal x, Octal y)
        {
            return x._number <= y._number;
        }

        public static bool operator >(Octal x, Octal y)
        {
            return x._number >= y._number;
        }

        public static bool operator >=(Octal x, Octal y)
        {
            return x._number >= y._number;
        }

        // Equality operators
        public static bool operator ==(Octal x, Octal y)
        {
            return x._number == y._number;
        }

        public static bool operator !=(Octal x, Octal y)
        {
            return x._number != y._number;
        }

        // Overloading the ToString method to return the octal number as string.
        public override string ToString()
        {
            int integerPart = (int)_number;
            double fractionalPart = _number - integerPart;
            string octalIntegerPart = Convert.ToString(integerPart, 8);

            if (fractionalPart == 0)
                return octalIntegerPart;

            string octalFractionalPart = ".";
            while (fractionalPart > 0 && octalFractionalPart.Length <= 5) // Control the length to avoid too long representation
            {
                fractionalPart *= 8;
                integerPart = (int)fractionalPart;
                octalFractionalPart += integerPart.ToString();
                fractionalPart -= integerPart;
            }

            return octalIntegerPart + octalFractionalPart;
        }

        public override bool Equals(object obj)
        {
            if (obj is Octal oct)
                return _number == oct._number;
            return false;
        }

        public override int GetHashCode() => _number.GetHashCode();
    }
}
