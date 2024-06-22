using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai1
{
    public class ThongKe
    {
        private int soLuongSach;
        private int tongSoTrang;
        private decimal tongGia;
        private decimal giaMax;
        private decimal giaMin;
        private MangChuoi cacTacGia;

        public ThongKe()
        {
            soLuongSach = 0;
            tongSoTrang = 0;
            tongGia = 0.0m;
            giaMax = decimal.MinValue;
            giaMin = decimal.MaxValue;
            cacTacGia = new MangChuoi();
        }

        public void KiemDuyet(Sach book)
        {
            soLuongSach++;
            tongSoTrang += book.SoTrang;
            tongGia += book.GiaBan;
            if (book.GiaBan > giaMax)
            {
                giaMax = book.GiaBan;
            }
            if (book.GiaBan < giaMin)
            {
                giaMin = book.GiaBan;
            }
            cacTacGia.Them(book.TacGia);
        }

        public decimal TinhGiaTrungBinhMoiSach()
        {
            return soLuongSach == 0 ? 0 : tongGia / soLuongSach;
        }

        public decimal TinhGiaTrungBinhMoiTrang()
        {
            return tongSoTrang == 0 ? 0 : tongGia / tongSoTrang;
        }

        public MangChuoi LayDanhSachTacGia()
        {
            return cacTacGia;
        }

        public int DemSoLuongTacGia()
        {
            return cacTacGia.SoLuong;
        }

        public decimal GiaMax()
        {
            return giaMax;
        }

        public decimal GiaMin()
        {
            return giaMin;
        }

        public decimal TinhSoTrangTrungBinhMoiSach()
        {
            return soLuongSach == 0 ? 0 : (decimal)tongSoTrang / soLuongSach;
        }
    }
}
