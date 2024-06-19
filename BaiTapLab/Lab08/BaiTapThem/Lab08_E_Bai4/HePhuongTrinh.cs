using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai4
{
    public class HePhuongTrinh : IPhuongTrinh
    {
        private double a1, b1, c1;  // Hệ số của phương trình thứ nhất
        private double a2, b2, c2;  // Hệ số của phương trình thứ hai

        public HePhuongTrinh(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
        }

        public void Giai()
        {
            double D = a1 * b2 - a2 * b1;
            double Dx = c1 * b2 - c2 * b1;
            double Dy = a1 * c2 - a2 * c1;

            if (D == 0)
            {
                if (Dx == 0 && Dy == 0)
                    Console.WriteLine("Hệ phương trình có vô số nghiệm.");
                else
                    Console.WriteLine("Hệ phương trình vô nghiệm.");
            }
            else
            {
                double x = Dx / D;
                double y = Dy / D;
                Console.WriteLine($"Hệ phương trình có nghiệm duy nhất: x = {x}, y = {y}");
            }
        }
    }

}
