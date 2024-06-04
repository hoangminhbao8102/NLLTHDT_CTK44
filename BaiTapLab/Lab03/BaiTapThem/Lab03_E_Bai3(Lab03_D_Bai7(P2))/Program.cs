using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai3_Lab03_D_Bai7_P2__
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize fx with predefined values
            DaThuc fx = new DaThuc();
            fx.Them(new DonThuc(3, 2));  // 3x^2
            fx.Them(new DonThuc(2, 1));  // 2x
            fx.Them(new DonThuc(1, 0));  // 1

            // Create gx based on user input
            DaThuc gx = new DaThuc();
            Console.WriteLine("Enter the number of terms for gx:");
            int numTerms = int.Parse(Console.ReadLine());
            for (int i = 0; i < numTerms; i++)
            {
                Console.WriteLine($"Enter coefficient and exponent for term {i + 1}:");
                double coef = double.Parse(Console.ReadLine());
                int exp = int.Parse(Console.ReadLine());
                gx.Them(new DonThuc(coef, exp));
            }

            // Output fx and gx
            Console.WriteLine("Polynomial fx:");
            fx.Xuat();
            Console.WriteLine("Polynomial gx:");
            gx.Xuat();

            // Output degrees of fx and gx
            Console.WriteLine($"Degree of fx: {fx.TimBac()}");
            Console.WriteLine($"Degree of gx: {gx.TimBac()}");

            // Perform and output addition and multiplication of fx and gx
            DaThuc sum = fx.Cong(gx);
            DaThuc product = fx.Nhan(gx);
            Console.WriteLine("Sum of fx and gx:");
            sum.Xuat();
            Console.WriteLine("Product of fx and gx:");
            product.Xuat();

            // Calculate and output the value of fx and gx for a user-specified value of x
            Console.WriteLine("Enter a value for x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Value of fx at x={x}: {fx.TinhGiaTri(x)}");
            Console.WriteLine($"Value of gx at x={x}: {gx.TinhGiaTri(x)}");

            // Output the number of non-zero terms in fx
            Console.WriteLine($"Number of non-zero terms in fx: {fx.DemSoDonThuc()}");

            Console.ReadKey();
        }
    }
}
