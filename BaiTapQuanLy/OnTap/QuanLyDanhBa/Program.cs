using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MenuDanhBa menu = new MenuDanhBa();

            menu.Run();

            Console.ReadKey();
        }
    }
}
