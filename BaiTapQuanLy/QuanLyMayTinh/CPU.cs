using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class CPU : IThietBi
    {
        float gia; //field
        string hangSX;
        float tocDo; // thêm thuộc tính Tốc độ

        public float Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public string HangSX
        {
            get
            {
                return hangSX;
            }

            set
            {
                hangSX = value;
                ThuVienDungChung.Them(value);
            }
        }

        public float TocDo
        {
            get
            {
                return tocDo;
            }

            set
            {
                tocDo = value;
            }
        }

        public CPU() { }

        public CPU(string hang, float gia, float tocDo)
        {
            HangSX = hang;
            Gia = gia;
            TocDo = tocDo;
        }

        public CPU(string line)
        {
            string[] s = line.Split(',');
            HangSX = s[1];
            Gia = float.Parse(s[2]);
            TocDo = float.Parse(s[3]);
        }

        public override string ToString()
        {
            return "CPU hãng " + HangSX + " giá = " + Gia + " tốc độ = " + TocDo;
        }
    }
}
