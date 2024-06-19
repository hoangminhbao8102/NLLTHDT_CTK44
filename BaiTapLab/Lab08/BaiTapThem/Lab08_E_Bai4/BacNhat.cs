using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai4
{
    public class BacNhat : IPhuongTrinh
    {
        private double a, b;

        public BacNhat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Giai()
        {
            if (a == 0)
            {
                Console.WriteLine(b == 0 ? "Phương trình có vô số nghiệm." : "Phương trình vô nghiệm.");
            }
            else
            {
                Console.WriteLine($"Nghiệm của phương trình là x = {-b / a}");
            }
        }
    }
}
