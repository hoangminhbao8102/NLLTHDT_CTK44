using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai3
{
    public delegate void XuLyViecPhatHanh(Bao baiBao);

    public class ToaSoan
    {
        private DanhSachDocGia _docGia;
        private string _ten;
        private int _doanhThu;

        public int DoanhThu
        { 
            get { return _doanhThu; } 
        }
        public string Ten
        { 
            get { return _ten; }
            set { _ten = value; }
        }

        public ToaSoan()
        {
            _docGia = new DanhSachDocGia();
            _ten = "Tên Tòa Soạn";
            _doanhThu = 0;
        }

        public ToaSoan(string tenToaSoan)
        {
            _docGia = new DanhSachDocGia();
            _ten = tenToaSoan;
            _doanhThu = 0;
        }

        protected virtual void PhatSinhSuKienPhatHanh(Bao baiBao)
        {
            PhatHanh?.Invoke(baiBao);
        }

        public void ThemDangKy(DocGia dg)
        {
            _docGia.Them(dg);
        }

        public override string ToString()
        {
            return $"Tên Tòa Soạn: {_ten}, Tổng Độc Giả: {_docGia.SoLuong}";
        }

        public void XoaDangKy(DocGia dg)
        {
            _docGia.Xoa(dg);
        }

        public int XuatBan(Bao baiBao)
        {
            _doanhThu += baiBao.GiaBan * baiBao.SoBao;
            PhatSinhSuKienPhatHanh(baiBao);
            return _doanhThu;
        }

        public void XuatDanhSachDocGia()
        {
            Console.WriteLine(_docGia.ToString());
        }

        public event XuLyViecPhatHanh PhatHanh;
    }
}
