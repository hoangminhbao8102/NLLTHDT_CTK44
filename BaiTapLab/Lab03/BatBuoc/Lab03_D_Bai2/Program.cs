using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            QuaBong red = new QuaBong(0, 0, 0, 5);
            QuaBong blue = new QuaBong(10, 10, 10, 7);

            Console.WriteLine($"Red ball volume: {red.TinhTheTich():F2}");
            Console.WriteLine($"Blue ball volume: {blue.TinhTheTich():F2}");

            Console.WriteLine($"The {(red.TinhTheTich() > blue.TinhTheTich() ? "red" : "blue")} ball has the larger volume.");

            red.DichChuyen(5, 5, 5);
            blue.DichChuyen(-5, -5, -5);

            Console.WriteLine($"New position of red ball: {red}");
            Console.WriteLine($"New position of blue ball: {blue}");

            bool collision = red.DungDo(blue);
            Console.WriteLine($"The balls are {(collision ? "" : "not ")}colliding.");

            Console.ReadKey();
        }
    }
}
