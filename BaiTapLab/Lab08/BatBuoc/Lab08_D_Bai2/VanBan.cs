using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai2
{
    class VanBan : ILuuTru, IInAn
    {
        private MangChuoi _noiDung;

        public int SoTrang 
        {
            get { return _noiDung.SoLuong; }
        }

        public void In()
        {
            // Print the entire content of _noiDung
            for (int i = 0; i < SoTrang; i++)
            {
                Console.WriteLine(_noiDung[i]);
            }
        }

        public void In(int begin, int end)
        {
            // Print the content of _noiDung from a specific range of pages
            for (int i = begin; i <= end && i < SoTrang; i++)
            {
                Console.WriteLine(_noiDung[i]);
            }
        }

        public void Luu(TextWriter writer)
        {
            // Save all the content in _noiDung to a file
            for (int i = 0; i < SoTrang; i++)
            {
                writer.WriteLine(_noiDung[i]);
            }
        }

        public VanBan(string tapTin)
        {
            // Initialize the MangChuoi instance with the content read from a file
            string[] content = File.ReadAllLines(tapTin);
            _noiDung = new MangChuoi(content);
        }
    }
}
