using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai2
{
    class Macintosh : HeDieuHanh
    {
        public Macintosh(string phienBan, DateTime ngayPh, float gia) : base(phienBan, ngayPh, gia)
        {
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("Hệ điều hành Macintosh:");
            base.XuatThongTin();
        }
    }
}
