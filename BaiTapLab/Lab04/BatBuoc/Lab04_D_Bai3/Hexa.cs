using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai3
{
    public class Hexa
    {
        private uint _number;

        // Explicit conversion from Hexa to int
        public static explicit operator int(Hexa x)
        {
            return Convert.ToInt32(x._number.ToString(), 16);
        }

        // Explicit conversion from Hexa to uint
        public static explicit operator uint(Hexa x)
        {
            return x._number;
        }

        // Implicit conversion from uint to Hexa
        public static implicit operator Hexa(uint k)
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
        public Hexa(uint conSo)
        {
            _number = conSo;
        }

        // Overloading the + operator
        public static Hexa operator +(Hexa x, Hexa y)
        {
            int result = ((int)x + (int)y);
            return new Hexa(Convert.ToUInt32(result.ToString(), 16));
        }

        // Overloading the - operator
        public static Hexa operator -(Hexa x, Hexa y)
        {
            int result = Math.Abs((int)x - (int)y);
            return new Hexa(Convert.ToUInt32(result.ToString(), 16));
        }

        // Overloading the * operator
        public static Hexa operator *(Hexa x, Hexa y)
        {
            int result = ((int)x * (int)y);
            return new Hexa(Convert.ToUInt32(result.ToString(), 16));
        }

        // Overloading the / operator
        public static Hexa operator /(Hexa x, Hexa y)
        {
            int result = ((int)x / (int)y);
            return new Hexa(Convert.ToUInt32(result.ToString(), 16));
        }

        // Modulo operator
        public static Hexa operator %(Hexa x, Hexa y)
        {
            int result = ((int)x % (int)y);
            return new Hexa(Convert.ToUInt32(result.ToString(), 16));
        }

        // Decrement operator
        public static Hexa operator --(Hexa x)
        {
            int result = (int)x - 1;
            return new Hexa(Convert.ToUInt32(result.ToString(), 16));
        }

        // Increment operator
        public static Hexa operator ++(Hexa x)
        {
            int result = (int)x + 1;
            return new Hexa(Convert.ToUInt32(result.ToString(), 16));
        }

        // Comparison operators
        public static bool operator <(Hexa x, Hexa y)
        {
            return (int)x < (int)y;
        }

        public static bool operator <=(Hexa x, Hexa y)
        {
            return (int)x <= (int)y;
        }

        public static bool operator >(Hexa x, Hexa y)
        {
            return (int)x > (int)y;
        }

        public static bool operator >=(Hexa x, Hexa y)
        {
            return (int)x >= (int)y;
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
            return Convert.ToString((int)this, 16);
        }

        // Overriding Equals and GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Hexa hex)
                return _number == hex._number;
            return false;
        }

        public override int GetHashCode() => _number.GetHashCode();
    }
}
