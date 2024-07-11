using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class RAM : CPU
    {
        float dungLuong; // thêm thuộc tính Dung lượng

        public float DungLuong
        {
            get
            {
                return dungLuong;
            }

            set
            {
                dungLuong = value;
            }
        }

        public RAM() { }

        public RAM(string line) : base(line)
        {
            string[] s = line.Split(',');
            HangSX = s[1];
            Gia = float.Parse(s[2]);
            TocDo = float.Parse(s[3]);
            DungLuong = float.Parse(s[4]);
        }

        public override string ToString()
        {
            return "RAM hãng " + HangSX + " giá = " + Gia + " dung lượng = " + DungLuong;
        }
    }
}
