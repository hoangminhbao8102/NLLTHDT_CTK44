using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai4
{
    public class Kelvin
    {
        private double _degree;
        public const double HighLevel = 310.15; // Ví dụ, nhiệt độ cơ thể cao bằng Kelvin
        public const double LowLevel = 273.15;  // Ví dụ, điểm đóng băng của nước bằng Kelvin

        public double Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }

        public Kelvin(double temperature)
        {
            _degree = temperature;
        }

        // Conversion from Kelvin to double (explicit)
        public static explicit operator double(Kelvin k)
        {
            return k._degree;
        }

        // Conversion from double to Kelvin (implicit)
        public static implicit operator Kelvin(double temperature)
        {
            return new Kelvin(temperature);
        }

        // Implicit conversions from Celsius and Fahrenheit to Kelvin
        public static implicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.Degree + 273.15);
        }

        public static implicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.Degree - 32) * 5.0 / 9.0 + 273.15);
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
        public static Kelvin operator +(Kelvin x, Kelvin y)
        {
            return new Kelvin(x._degree + y._degree);
        }

        // Overloading the - operator
        public static Kelvin operator -(Kelvin x, Kelvin y)
        {
            return new Kelvin(x._degree - y._degree);
        }

        // Overloading increment and decrement operators
        public static Kelvin operator ++(Kelvin x)
        {
            return new Kelvin(x._degree + 1);
        }

        public static Kelvin operator --(Kelvin x)
        {
            return new Kelvin(x._degree - 1);
        }

        // Comparison operators
        public static bool operator <(Kelvin x, Kelvin y)
        {
            return x._degree < y._degree;
        }

        public static bool operator <=(Kelvin x, Kelvin y)
        {
            return x._degree <= y._degree;
        }

        public static bool operator >(Kelvin x, Kelvin y)
        {
            return x._degree > y._degree;
        }

        public static bool operator >=(Kelvin x, Kelvin y)
        {
            return x._degree >= y._degree;
        }

        // Equality operators
        public static bool operator ==(Kelvin x, Kelvin y)
        {
            return x._degree == y._degree;
        }

        public static bool operator !=(Kelvin x, Kelvin y)
        {
            return x._degree != y._degree;
        }

        // Overriding ToString() to display temperature in Kelvin
        public override string ToString()
        {
            return $"{_degree} K";
        }

        // Overriding Equals and GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Kelvin k)
            {
                return _degree == k._degree;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _degree.GetHashCode();
        }
    }
}
