using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MenuMayTinh menu = new MenuMayTinh();

            menu.Run();

            Console.ReadKey();
        }
    }
}
