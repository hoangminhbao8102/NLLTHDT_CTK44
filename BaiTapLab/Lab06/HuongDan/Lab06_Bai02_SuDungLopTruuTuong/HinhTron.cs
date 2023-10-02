using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Bai02_SuDungLopTruuTuong
{
    public class HinhTron : HinhHoc
    {
        public double BanKinh
        {
            get { return canh; }
        }

        public HinhTron(double banKinh) : base(banKinh)
        {
            
        }

        public override double TinhDienTich()
        {
            return canh * canh * Math.PI;
        }

        public override void Xuat()
        {
            Console.WriteLine("Hinh tron ban kinh {0}, dien tich = {1}", canh, TinhDienTich());
        }
    }
}
