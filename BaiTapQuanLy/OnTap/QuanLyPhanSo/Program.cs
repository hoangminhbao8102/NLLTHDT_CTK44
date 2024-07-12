using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MenuPhanSo menu = new MenuPhanSo();

            menu.Run();

            Console.ReadKey();
        }
    }
}
