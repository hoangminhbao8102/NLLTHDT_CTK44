using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai4
{
    public class BacBa : IPhuongTrinh
    {
        private double a, b, c, d;

        public BacBa(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public void Giai()
        {
            if (a == 0)
            {
                // Nếu a = 0, không phải là phương trình bậc ba
                Console.WriteLine("Không phải phương trình bậc ba.");
            }
            else
            {
                // Đưa về dạng x^3 + px + q = 0 bằng cách chia cả phương trình cho a và đặt x = y - b/(3a)
                double p = (3 * a * c - b * b) / (3 * a * a);
                double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);
                double deltaOver4 = (q * q) / 4 + (p * p * p) / 27;

                if (deltaOver4 > 0) // Một nghiệm thực và hai nghiệm phức
                {
                    double u = Math.Pow(-q / 2 + Math.Sqrt(deltaOver4), 1.0 / 3.0);
                    double v = Math.Pow(-q / 2 - Math.Sqrt(deltaOver4), 1.0 / 3.0);
                    double x1 = u + v - b / (3 * a);
                    Console.WriteLine($"Phương trình có một nghiệm thực: x = {x1}");
                }
                else if (deltaOver4 == 0) // Ba nghiệm thực và ít nhất hai nghiệm bằng nhau
                {
                    double x1 = 3 * q / p - b / (3 * a);
                    double x2 = -3 * q / (2 * p) - b / (3 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = {x1}, và một nghiệm khác x3 = {x2}");
                }
                else // Ba nghiệm thực phân biệt
                {
                    double r = Math.Sqrt(-p / 3);
                    double phi = Math.Acos(-q / (2 * r * r * r)) / 3;
                    double x1 = 2 * r * Math.Cos(phi) - b / (3 * a);
                    double x2 = 2 * r * Math.Cos(phi + 2 * Math.PI / 3) - b / (3 * a);
                    double x3 = 2 * r * Math.Cos(phi - 2 * Math.PI / 3) - b / (3 * a);
                    Console.WriteLine($"Phương trình có ba nghiệm phân biệt: x1 = {x1}, x2 = {x2}, x3 = {x3}");
                }
            }
        }
    }
}
