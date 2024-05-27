using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random random = new Random();
            int targetNumber = random.Next(0, 1001); // Sinh số ngẫu nhiên từ 0 đến 1000
            int maxAttempts = 10; // Giới hạn số lần đoán
            int attempts = 0;
            bool hasWon = false;

            Console.WriteLine("Chào mừng bạn đến với trò chơi đoán số!");
            Console.WriteLine("Bạn hãy đoán một số từ 0 đến 1000. Bạn có 10 lần đoán.");

            while (attempts < maxAttempts && !hasWon)
            {
                Console.Write("Nhập số đoán của bạn: ");
                int guess;
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ!");
                    continue; // Nếu nhập không phải số, yêu cầu nhập lại
                }

                if (guess < targetNumber)
                {
                    Console.WriteLine("Nhỏ hơn.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Lớn hơn.");
                }
                else
                {
                    hasWon = true;
                    Console.WriteLine("Chúc mừng! Bạn đã đoán đúng số.");
                    break;
                }

                attempts++;
                Console.WriteLine($"Bạn còn {maxAttempts - attempts} lần đoán.");
            }

            if (!hasWon)
            {
                Console.WriteLine($"Bạn đã thua. Số cần đoán là {targetNumber}.");
            }

            Console.ReadKey();
        }
    }
}
