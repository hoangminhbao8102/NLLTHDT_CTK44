using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai2_Hexa_P2__
{
    public class Hexa
    {
        private double _number;

        // Explicit conversion from Hexa to int
        public static explicit operator int(Hexa x)
        {
            return Convert.ToInt32(x._number.ToString(), 16);
        }

        // Explicit conversion from Hexa to double
        public static explicit operator double(Hexa x)
        {
            return x._number;
        }

        // Implicit conversion from double to Hexa
        public static implicit operator Hexa(double k)
        {
            return new Hexa(k);
        }

        // Implicit conversion from string to Hexa
        public static implicit operator Hexa(string k)
        {
            try
            {
                uint number = Convert.ToUInt32(k, 16);
                return new Hexa(number);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Invalid hexadecimal number format.");
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Hexadecimal number is too large.");
            }
        }

        // Constructor
        public Hexa(double conSo)
        {
            _number = Math.Round(conSo, 3); // Round to ensure three decimal places precision
        }

        // Overloading the + operator
        public static Hexa operator +(Hexa x, Hexa y)
        {
            return new Hexa(x._number + y._number);
        }

        // Overloading the - operator
        public static Hexa operator -(Hexa x, Hexa y)
        {
            return new Hexa(x._number - y._number);
        }

        // Overloading the * operator
        public static Hexa operator *(Hexa x, Hexa y)
        {
            return new Hexa(x._number * y._number);
        }

        // Overloading the / operator
        public static Hexa operator /(Hexa x, Hexa y)
        {
            return new Hexa(x._number / y._number);
        }

        // Modulo operator
        public static Hexa operator %(Hexa x, Hexa y)
        {
            return new Hexa(x._number % y._number);
        }

        // Decrement operator
        public static Hexa operator --(Hexa x)
        {
            return new Hexa(x._number - 1);
        }

        // Increment operator
        public static Hexa operator ++(Hexa x)
        {
            return new Hexa(x._number + 1);
        }

        // Comparison operators
        public static bool operator <(Hexa x, Hexa y)
        {
            return x._number < y._number;
        }

        public static bool operator <=(Hexa x, Hexa y)
        {
            return x._number <= y._number;
        }

        public static bool operator >(Hexa x, Hexa y)
        {
            return x._number > y._number;
        }

        public static bool operator >=(Hexa x, Hexa y)
        {
            return x._number >= y._number;
        }

        // Equality operators
        public static bool operator ==(Hexa x, Hexa y)
        {
            return x._number == y._number;
        }

        public static bool operator !=(Hexa x, Hexa y)
        {
            return x._number != y._number;
        }

        // Overloading the ToString method to return the hexadecimal number as string.
        public override string ToString()
        {
            return _number.ToString("X");
        }

        // Overriding Equals and GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Hexa hex)
                return Math.Abs(_number - hex._number) < 0.0001;
            return false;
        }

        public override int GetHashCode() => _number.GetHashCode();
    }
}
