using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai4
{
    public class Celsius
    {
        private double _degree;
        // Constants for HighLevel and LowLevel
        public const double HighLevel = 37.0;  // For example, body temperature in Celsius
        public const double LowLevel = 0.0;    // For example, freezing point of water

        public double Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }

        public Celsius(double temperature)
        {
            _degree = temperature;
        }

        // Conversion from Celsius to double (explicit)
        public static explicit operator double(Celsius x)
        {
            return x._degree;
        }

        // Conversion from double to Celsius (implicit)
        public static implicit operator Celsius(double temperature)
        {
            return new Celsius(temperature);
        }

        // Implicit conversions from Fahrenheit and Kelvin to Celsius
        public static implicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.Degree - 32) * 5.0 / 9.0);
        }

        public static implicit operator Celsius(Kelvin c)
        {
            return new Celsius(c.Degree - 273.15);
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
        public static Celsius operator +(Celsius x, Celsius y)
        {
            return new Celsius(x._degree + y._degree);
        }

        // Overloading the - operator
        public static Celsius operator -(Celsius x, Celsius y)
        {
            return new Celsius(x._degree - y._degree);
        }

        // Overloading the * operator
        public static Celsius operator *(Celsius x, double multiplier)
        {
            return new Celsius(x._degree * multiplier);
        }

        // Overloading the / operator
        public static Celsius operator /(Celsius x, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return new Celsius(x._degree / divisor);
        }

        // Overloading increment and decrement operators
        public static Celsius operator ++(Celsius x)
        {
            return new Celsius(x._degree + 1);
        }

        public static Celsius operator --(Celsius x)
        {
            return new Celsius(x._degree - 1);
        }

        // Comparison operators
        public static bool operator <(Celsius x, Celsius y)
        {
            return x._degree < y._degree;
        }

        public static bool operator <=(Celsius x, Celsius y)
        {
            return x._degree <= y._degree;
        }

        public static bool operator >(Celsius x, Celsius y)
        {
            return x._degree > y._degree;
        }

        public static bool operator >=(Celsius x, Celsius y)
        {
            return x._degree >= y._degree;
        }

        // Equality operators
        public static bool operator ==(Celsius x, Celsius y)
        {
            return x._degree == y._degree;
        }

        public static bool operator !=(Celsius x, Celsius y)
        {
            return x._degree != y._degree;
        }

        // Overriding ToString() to display temperature in Celsius
        public override string ToString()
        {
            return $"{_degree} °C";
        }

        // Overriding Equals and GetHashCode
        public override bool Equals(object obj)
        {
            return obj is Celsius c && c._degree == _degree;
        }

        public override int GetHashCode()
        {
            return _degree.GetHashCode();
        }
    }
}
