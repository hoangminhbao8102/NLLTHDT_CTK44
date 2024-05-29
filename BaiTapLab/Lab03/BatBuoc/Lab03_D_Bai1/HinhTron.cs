using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai1
{
    public class HinhTron
    {
        private double _banKinh;
        private string _mau;

        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }

        public string MauSac
        {
            get { return _mau; }
            set { _mau = value; }
        }

        public HinhTron(double banKinh)
        {
            _banKinh = banKinh;
            _mau = "Không màu"; // Mặc định là không màu nếu không được cung cấp
        }

        public HinhTron(double banKinh, string mau)
        {
            _banKinh = banKinh;
            _mau = mau;
        }

        public void BienDoiTyLe(double tyLe)
        {
            _banKinh *= tyLe / 100;
        }

        public double TinhDienTich()
        {
            return Math.PI * _banKinh * _banKinh;
        }

        public double TinhChuVi()
        {
            return 2 * Math.PI * _banKinh;
        }

        public override string ToString()
        {
            return $"Hình Tròn: Bán kính = {_banKinh}, Màu = {_mau}, Diện tích = {TinhDienTich()}, Chu vi = {TinhChuVi()}";
        }
    }
}
