using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai3
{
    public class DocGia
    {
        private string _hoTen;
        private string _diaChi;
        private int _maSo;

        public int MaSo
        { 
            get { return _maSo; } 
            set { _maSo = value; } 
        }
        public string HoTen
        { 
            get { return _hoTen; } 
            set { _hoTen = value; } 
        }
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public DocGia()
        {
            _hoTen = "Không rõ";
            _diaChi = "Không rõ";
            _maSo = 0;
        }

        public DocGia(int maSo, string hoTen, string diaChi)
        {
            _maSo = maSo;
            _hoTen = hoTen;
            _diaChi = diaChi;
        }

        public override string ToString()
        {
            return $"Mã Số: {_maSo}, Họ Tên: {_hoTen}, Địa Chỉ: {_diaChi}";
        }

        public void DangKy(ToaSoan ts)
        {
            ts.ThemDangKy(this);
        }

        public void HuyDichVu(ToaSoan ts) 
        {
            ts.XoaDangKy(this);
        }

        private void DocBao(Bao baiBao)
        {
            Console.WriteLine($"Độc giả {_hoTen} đang đọc báo với nội dung: {baiBao.NoiDung}");
        }
    }
}
