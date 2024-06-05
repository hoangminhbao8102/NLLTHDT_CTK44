using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai4
{
    public class Fahrenheit
    {
        private double _degree;
        public const double HighLevel = 98.6; // Normal body temperature in Fahrenheit
        public const double LowLevel = 32.0;  // Freezing point of water in Fahrenheit

        public double Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }

        public Fahrenheit(double degree)
        {
            _degree = degree;
        }

        // Conversion from Fahrenheit to double (explicit)
        public static explicit operator double(Fahrenheit f)
        {
            return f._degree;
        }

        // Conversion from double to Fahrenheit (implicit)
        public static implicit operator Fahrenheit(double degree)
        {
            return new Fahrenheit(degree);
        }

        // Implicit conversions from Celsius and Kelvin to Fahrenheit
        public static implicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.Degree * 9.0 / 5.0 + 32);
        }

        public static implicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.Degree - 273.15) * 9.0 / 5.0 + 32);
        }

        // Check if the temperature is unusually high
        public bool IsHighNorm()
        {
            return _degree > HighLevel;
        }

        // Check if the temperature is unusually low
        public bool IsLowNorm()
        {
            return _degree < LowLevel;
        }

        // Overloading the + operator
        public static Fahrenheit operator +(Fahrenheit x, Fahrenheit y)
        {
            return new Fahrenheit(x._degree + y._degree);
        }

        // Overloading the - operator
        public static Fahrenheit operator -(Fahrenheit x, Fahrenheit y)
        {
            return new Fahrenheit(x._degree - y._degree);
        }

        // Overloading increment and decrement operators
        public static Fahrenheit operator ++(Fahrenheit x)
        {
            return new Fahrenheit(x._degree + 1);
        }

        public static Fahrenheit operator --(Fahrenheit x)
        {
            return new Fahrenheit(x._degree - 1);
        }

        // Comparison operators
        public static bool operator <(Fahrenheit x, Fahrenheit y)
        {
            return x._degree < y._degree;
        }

        public static bool operator <=(Fahrenheit x, Fahrenheit y)
        {
            return x._degree <= y._degree;
        }

        public static bool operator >(Fahrenheit x, Fahrenheit y)
        {
            return x._degree > y._degree;
        }

        public static bool operator >=(Fahrenheit x, Fahrenheit y)
        {
            return x._degree >= y._degree;
        }

        // Equality operators
        public static bool operator ==(Fahrenheit x, Fahrenheit y)
        {
            return x._degree == y._degree;
        }

        public static bool operator !=(Fahrenheit x, Fahrenheit y)
        {
            return x._degree != y._degree;
        }

        // Overriding ToString() to display temperature in Fahrenheit
        public override string ToString()
        {
            return $"{_degree} °F";
        }

        // Overriding Equals and GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Fahrenheit f)
            {
                return _degree == f._degree;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _degree.GetHashCode();
        }
    }
}
