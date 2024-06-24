using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_E_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tạo 10 quả bom và kết nối chúng
            Bomb[] bombs = new Bomb[10];
            for (int i = 0; i < 10; i++)
            {
                bombs[i] = new Bomb(i + 1);
                if (i > 0)
                {
                    bombs[i - 1].ConnectedBomb = bombs[i];
                }
            }

            // Thiết lập đồng hồ hẹn giờ với thông báo đe dọa
            Timer timer = new Timer(10, 5, "WARNING: All exits are locked. Authorities have 5 seconds to disarm the bombs!", bombs[0]);
            timer.StartCountdown();

            Console.ReadKey();
        }
    }
}
