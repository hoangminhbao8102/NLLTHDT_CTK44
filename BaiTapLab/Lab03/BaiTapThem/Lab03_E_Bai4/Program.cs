using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Computer acer = new Computer
            {
                Board = new MainBoard { Gia = 1500, HangSX = "Acer", TocDoBus = 1600 },
                CdRom = new CDROM { Gia = 100, TocDo = "52X" },
                Cpu = new CPU { Gia = 2200, SoLoi = 4, TocDo = 3.5f },
                Hdd = new HDD { Gia = 300, DungLuong = 500, TocDoQuay = 7200 },
                Ram = new RAM { Gia = 400, DungLuong = 8 }
            };

            Computer vaio = new Computer
            {
                Board = new MainBoard { Gia = 1700, HangSX = "Vaio", TocDoBus = 1800 },
                CdRom = new CDROM { Gia = 120, TocDo = "48X" },
                Cpu = new CPU { Gia = 2500, SoLoi = 8, TocDo = 4.0f },
                Hdd = new HDD { Gia = 500, DungLuong = 1000, TocDoQuay = 7200 },
                Ram = new RAM { Gia = 600, DungLuong = 16 }
            };

            Computer dell = new Computer
            {
                Board = new MainBoard { Gia = 1600, HangSX = "Dell", TocDoBus = 1600 },
                CdRom = new CDROM { Gia = 110, TocDo = "50X" },
                Cpu = new CPU { Gia = 2300, SoLoi = 6, TocDo = 3.7f },
                Hdd = new HDD { Gia = 350, DungLuong = 750, TocDoQuay = 7200 },
                Ram = new RAM { Gia = 450, DungLuong = 12 }
            };

            Console.WriteLine("Brand    |CPU       |Speed   |HDD       |RAM      |Total Cost");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(acer);
            Console.WriteLine(vaio);
            Console.WriteLine(dell);

            Console.ReadKey();
        }
    }
}
