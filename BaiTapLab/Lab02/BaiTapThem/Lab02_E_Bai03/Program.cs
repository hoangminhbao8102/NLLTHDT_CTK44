using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập 9 chữ số đầu của số ISBN
            Console.Write("Nhập 9 chữ số đầu của số ISBN: ");
            string firstNineDigits = Console.ReadLine();

            if (firstNineDigits.Length != 9 || !long.TryParse(firstNineDigits, out _))
            {
                Console.WriteLine("Dữ liệu nhập không hợp lệ, phải có đúng 9 chữ số.");
                return;
            }

            // Tính toán chữ số cuối cùng
            int lastDigit = CalculateLastDigit(firstNineDigits);
            Console.WriteLine("Chữ số thứ 10 của ISBN là: " + lastDigit);

            Console.ReadKey();
        }

        static int CalculateLastDigit(string firstNineDigits)
        {
            int sum = 0;

            // Tính tổng d1 + 2*d2 + 3*d3 + ... + 9*d9
            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse(firstNineDigits[i].ToString());
                sum += (i + 1) * digit;
            }

            // Tìm chữ số thứ 10 sao cho tổng có dạng 11k
            for (int d10 = 0; d10 <= 10; d10++) // d10 có thể là số từ 0 đến 10, trong đó 10 đại diện cho 'X'
            {
                if ((sum + 10 * d10) % 11 == 0)
                {
                    return d10;
                }
            }

            return -1; // Trường hợp không tìm thấy, hiếm khi xảy ra
        }
    }
}
