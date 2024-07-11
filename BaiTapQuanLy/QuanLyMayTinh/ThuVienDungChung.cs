using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class ThuVienDungChung
    {
        public static List<string> dsHang = new List<string>();
        public static void Them(string hang)
        {
            if (dsHang.Contains(hang))
            {
                return;
            }
            dsHang.Add(hang);
        }
    }
}
