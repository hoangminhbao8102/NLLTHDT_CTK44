using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.Write("Hello, ");
            Console.Write("World!");
            Console.WriteLine();
            
            Console.WriteLine("Hello, " + "World!");
            
            Console.WriteLine("Da xuat chuoi Hello, World! " + 3 + " lan roi");
            
            Console.ReadKey();
        }
    }
}
