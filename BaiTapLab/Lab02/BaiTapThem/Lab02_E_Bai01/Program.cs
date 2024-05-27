using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai01
{
    public class Program
    {
        static int Ackerman(int x, int y)
        {
            if (y >= 0 && x == 0)
                return 1; // A(0, y) = 1 khi y >= 0
            else if (x == 1 && y == 0)
                return 2; // A(1, 0) = 2
            else if (y == 0 && x >= 0)
                return x + 2; // A(x, 0) = x + 2 khi x >= 0
            else if (x >= 1 && y >= 1)
                return Ackerman(x - 1, Ackerman(x, y - 1)); // A(x, y) = A(x - 1, A(x, y - 1)) khi x và y >= 1

            return 0; // Trường hợp còn lại không xác định, trả về 0 hoặc có thể xử lý khác
        }

        static void Main(string[] args)
        {
            // Test function with some example values
            Console.WriteLine("Ackerman(0, 1): " + Ackerman(0, 1));
            Console.WriteLine("Ackerman(1, 0): " + Ackerman(1, 0));
            Console.WriteLine("Ackerman(2, 0): " + Ackerman(2, 0));
            Console.WriteLine("Ackerman(1, 1): " + Ackerman(1, 1));
            Console.WriteLine("Ackerman(3, 3): " + Ackerman(3, 3));

            Console.ReadKey();
        }
    }
}
