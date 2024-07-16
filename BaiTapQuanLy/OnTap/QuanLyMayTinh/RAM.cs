using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class RAM : IThietBi
    {
        float gia;
        string hangSX;
        string model;
        int namSanXuat;
        float dungLuong; // Thêm thuộc tính dung lượng cho RAM

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
        public float DungLuong 
        { 
            get => dungLuong; 
            set => dungLuong = value; 
        }

        public RAM() { }

        public RAM(string hangSX, float gia, string model, int namSanXuat, float dungLuong)
        {
            HangSX = hangSX;
            Gia = gia;
            Model = model;
            NamSanXuat = namSanXuat;
            DungLuong = dungLuong;
        }

        public RAM(string line)
        {
            string[] elements = line.Split(',');
            HangSX = elements[0];
            Gia = float.Parse(elements[1]);
            Model = elements[2];
            NamSanXuat = int.Parse(elements[3]);
            DungLuong = float.Parse(elements[4]);
        }

        public override string ToString()
        {
            return $"RAM hãng {HangSX}, giá = {Gia}, model = {Model}, năm sản xuất = {NamSanXuat}, dung lượng = {DungLuong} GB";
        }
    }
}
