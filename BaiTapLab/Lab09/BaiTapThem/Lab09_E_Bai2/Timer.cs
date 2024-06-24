using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab09_E_Bai2
{
    public class Timer
    {
        private int countdownSeconds;
        private string threatMessage;
        private Bomb firstBomb;

        public Timer(int initialCount, int threatCount, string message, Bomb bomb)
        {
            countdownSeconds = initialCount + threatCount;
            threatMessage = message;
            firstBomb = bomb;
        }

        public void StartCountdown()
        {
            Console.WriteLine("Countdown started...");
            Thread.Sleep(countdownSeconds * 1000); // Giả lập thời gian chờ
            Console.WriteLine(threatMessage);
            firstBomb.Detonate();
        }
    }
}
