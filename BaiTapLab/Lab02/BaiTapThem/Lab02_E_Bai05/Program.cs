using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai05
{
    public class Program
    {
        // Hàm chuyển đổi số thành chuỗi
        static string NumberToString(int number)
        {
            return number.ToString();
        }

        static void Main(string[] args)
        {
            int number = 12345;
            string numberAsString = NumberToString(number);
            Console.WriteLine(numberAsString);  // In ra: "12345"
            Console.ReadKey();
        }
    }
}
