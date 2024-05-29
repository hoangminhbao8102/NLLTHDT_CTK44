using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai7
{
    public class Program
    {
        static void Main(string[] args)
        {
            DaThuc fx = new DaThuc(new double[] { 1, 2, 3 }); // 3x^2 + 2x + 1

            Console.WriteLine("Enter the degree of polynomial gx:");
            int bac = int.Parse(Console.ReadLine());
            double[] heSoGx = new double[bac + 1];
            Console.WriteLine($"Enter the coefficients for polynomial gx from x^0 to x^{bac}:");
            for (int i = 0; i <= bac; i++)
            {
                heSoGx[i] = double.Parse(Console.ReadLine());
            }
            DaThuc gx = new DaThuc(heSoGx);

            Console.WriteLine("Polynomial fx:");
            fx.Xuat();
            Console.WriteLine("Polynomial gx:");
            gx.Xuat();

            Console.WriteLine($"Degree of fx: {fx.TimBac()}");
            Console.WriteLine($"Degree of gx: {gx.TimBac()}");

            DaThuc sum = fx.Cong(gx);
            DaThuc product = fx.Nhan(gx);

            Console.WriteLine("Sum of fx and gx:");
            sum.Xuat();
            Console.WriteLine("Product of fx and gx:");
            product.Xuat();

            Console.WriteLine("Enter a value for x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Value of fx at x={x}: {fx.TinhGiaTri(x)}");
            Console.WriteLine($"Value of gx at x={x}: {gx.TinhGiaTri(x)}");

            Console.WriteLine($"Number of non-zero terms in fx: {fx.DemSoDonThuc()}");

            Console.ReadKey();
        }
    }
}
