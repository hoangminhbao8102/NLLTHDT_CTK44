using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai8
{
    public class NgayThang
    {
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }

        public NgayThang(int ngay, int thang, int nam)
        {
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
        }

        public override string ToString()
        {
            return $"{Ngay}/{Thang}/{Nam}";
        }
    }
}
