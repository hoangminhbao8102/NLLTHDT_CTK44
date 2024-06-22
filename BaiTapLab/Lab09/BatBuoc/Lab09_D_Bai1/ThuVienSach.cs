using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai1
{
    public delegate void XuLySach(Sach book);

    public class ThuVienSach
    {
        private int soLuong;
        private Sach[] danhMuc;

        public ThuVienSach()
        {
            soLuong = 0;
            danhMuc = new Sach[100];
        }

        public void Them(Sach book)
        {
            if (soLuong < danhMuc.Length)
            {
                danhMuc[soLuong] = book;
                soLuong++;
            }
            else
            {
                // Optionally handle the case when the array is full
                Console.WriteLine("Danh mục sách đã đầy!");
            }
        }

        public void KiemDuyet(XuLySach hamXuLy)
        {
            for (int i = 0; i < soLuong; i++)
            {
                hamXuLy(danhMuc[i]);
            }
        }
    }
}
