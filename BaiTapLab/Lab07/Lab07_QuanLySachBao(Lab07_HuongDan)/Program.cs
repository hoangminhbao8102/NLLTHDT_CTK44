using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
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
