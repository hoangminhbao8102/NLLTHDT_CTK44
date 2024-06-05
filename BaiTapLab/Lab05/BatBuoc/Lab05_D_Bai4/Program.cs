using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Menu menu = new Menu();

            menu.Run();

            Console.ReadKey();
        }
    }
}
