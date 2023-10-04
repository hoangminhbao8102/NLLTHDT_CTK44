using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai1_Lab07_QuanLySachBao_P2__
{
    public class Program
    {
        static void Main(string[] args)
        {
            DanhSachTaiLieu thuVien = DuLieuNguon.TaoDanhSach();

            Console.WriteLine(thuVien);

            Console.ReadKey();
        }
    }
}
