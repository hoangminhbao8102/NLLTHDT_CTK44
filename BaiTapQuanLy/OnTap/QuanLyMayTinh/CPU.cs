using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class CPU : IThietBi
    {
        float gia;
        string hangSX;
        float tocDo;
        string model;
        int namSanXuat;

        public float Gia 
        { 
            get => gia;
            set => gia = value; 
        }
        public string HangSX 
        { 
            get => hangSX; 
            set
            {
                if (hangSX != value)
                {
                    hangSX = value;
                    ThuVienDungChung.Them(value);
                }
            }
        }
        public float TocDo
        {
            get => tocDo;
            set => tocDo = value;
        }
        public string Model 
        { 
            get => model;
            set => model = value;
        }
        public int NamSanXuat 
        { 
            get => namSanXuat; 
            set => namSanXuat = value; 
        }
        public CPU() { }

        public CPU(string hangSX, float gia, float tocDo, string model, int namSanXuat)
        {
            HangSX = hangSX;
            Gia = gia;
            TocDo = tocDo;
            Model = model;
            NamSanXuat = namSanXuat;
        }

        public CPU(string line)
        {
            string[] elements = line.Split(',');
            HangSX = elements[0];
            Gia = float.Parse(elements[1]);
            TocDo = float.Parse(elements[2]);
            Model = elements[3];
            NamSanXuat = int.Parse(elements[4]);
        }

        public override string ToString()
        {
            return $"CPU hãng {HangSX}, giá = {Gia}, tốc độ = {TocDo} GHz, model = {Model}, năm sản xuất = {NamSanXuat}";
        }
    }
}
