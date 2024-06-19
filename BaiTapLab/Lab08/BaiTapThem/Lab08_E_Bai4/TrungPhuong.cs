using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai4
{
    public class TrungPhuong : IPhuongTrinh
    {
        private double a, b, c;

        public TrungPhuong(double a, double b, double c)
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
                double y = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = {Math.Sqrt(y)}");
            }
            else
            {
                double y1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double y2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có các nghiệm x1 = {Math.Sqrt(y1)}, x2 = {-Math.Sqrt(y1)}, x3 = {Math.Sqrt(y2)}, x4 = {-Math.Sqrt(y2)}");
            }
        }
    }

}
