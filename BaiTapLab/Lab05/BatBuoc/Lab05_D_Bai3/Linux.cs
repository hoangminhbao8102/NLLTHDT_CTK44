using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai3
{
    public class Linux : HeDieuHanh
    {
        public Linux(string phienBan, DateTime ngayPh, float gia) : base(phienBan, ngayPh, gia)
        {
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("Thông tin Linux:");
            base.XuatThongTin();
        }
    }
}
