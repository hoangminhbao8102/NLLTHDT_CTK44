using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            HanoiTower tower = new HanoiTower(3);
            tower.Solve();

            Console.ReadKey();
        }
    }
}
