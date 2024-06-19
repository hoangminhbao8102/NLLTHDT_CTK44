using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai4
{
    public class BacHai : IPhuongTrinh
    {
        private double a, b, c;

        public BacHai(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Giai()
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = {-b / (2 * a)}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có hai nghiệm phân biệt x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
