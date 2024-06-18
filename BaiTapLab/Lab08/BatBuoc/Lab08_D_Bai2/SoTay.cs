using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai2
{
    class SoTay : ILuuTru, IInAn
    {
        private GhiChu[] lichNhacViec;
        private int soLuong;

        public int SoTrang 
        {
            get { return soLuong; }
        }

        public void In()
        {
            foreach (GhiChu viec in lichNhacViec)
            {
                if (viec != null)
                    Console.WriteLine(viec.ToString());
            }
        }

        public void In(int begin, int end)
        {
            foreach (GhiChu viec in lichNhacViec.Where(v => v != null && v.MaSo >= begin && v.MaSo <= end))
            {
                Console.WriteLine(viec.ToString());
            }
        }

        public void Luu(TextWriter writer)
        {
            foreach (GhiChu viec in lichNhacViec)
            {
                if (viec != null)
                    viec.Luu(writer);
            }
        }

        public SoTay()
        {
            lichNhacViec = new GhiChu[10]; // Assuming an initial capacity
            soLuong = 0;
        }

        public void Them(GhiChu viec)
        {
            if (soLuong == lichNhacViec.Length)
            {
                // Resize the array if necessary, doubling its size
                Array.Resize(ref lichNhacViec, lichNhacViec.Length * 2);
            }
            lichNhacViec[soLuong++] = viec;
        }
    }
}
