using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai2
{
    public class Octal
    {
        private uint _number;

        // Conversion from Octal to int (explicit).
        public static explicit operator int(Octal x)
        {
            return Convert.ToInt32(x._number.ToString(), 8);
        }

        // Conversion from Octal to uint (explicit).
        public static explicit operator uint(Octal x)
        {
            return x._number;
        }


        public static implicit operator Octal(uint k)
        {
            return new Octal(k);
        }

        public Octal(uint conSo)
        {
            _number = conSo;
        }

        // Overloading the + operator.
        public static Octal operator +(Octal x, Octal y)
        {
            int result = ((int)x + (int)y);
            return new Octal(Convert.ToUInt32(result.ToString(), 8));
        }

        // Overloading the - operator.
        public static Octal operator -(Octal x, Octal y)
        {
            int result = Math.Abs((int)x - (int)y);
            return new Octal(Convert.ToUInt32(result.ToString(), 8));
        }

        // Overloading the * operator.
        public static Octal operator *(Octal x, Octal y)
        {
            int result = ((int)x * (int)y);
            return new Octal(Convert.ToUInt32(result.ToString(), 8));
        }

        // Overloading the / operator.
        public static Octal operator /(Octal x, Octal y)
        {
            int result = ((int)x / (int)y);
            return new Octal(Convert.ToUInt32(result.ToString(), 8));
        }

        // Modulo operator
        public static Octal operator %(Octal x, Octal y)
        {
            int result = ((int)x % (int)y);
            return new Octal(Convert.ToUInt32(result.ToString(), 8));
        }

        // Decrement operator
        public static Octal operator --(Octal x)
        {
            int result = (int)x - 1;
            return new Octal(Convert.ToUInt32(result.ToString(), 8));
        }

        // Increment operator
        public static Octal operator ++(Octal x)
        {
            int result = (int)x + 1;
            return new Octal(Convert.ToUInt32(result.ToString(), 8));
        }

        // Comparison operators
        public static bool operator <(Octal x, Octal y)
        {
            return (int)x < (int)y;
        }

        public static bool operator <=(Octal x, Octal y)
        {
            return (int)x <= (int)y;
        }

        public static bool operator >(Octal x, Octal y)
        {
            return (int)x > (int)y;
        }

        public static bool operator >=(Octal x, Octal y)
        {
            return (int)x >= (int)y;
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
            return Convert.ToString((int)this, 8);
        }
    }
}
