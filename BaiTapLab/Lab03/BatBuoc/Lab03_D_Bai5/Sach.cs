using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai5
{
    public class Sach
    {
        // Fields
        private decimal _gia; // Price
        private int _soLuong; // Quantity
        private TacGia _tacGia; // Author
        private string _tuaDe; // Title

        // Properties
        public decimal Gia { get; set; }
        public int SoLuongTon { get; set; }
        public TacGia TacGia { get; set; }
        public string TuaDe { get; set; }

        // Constructors
        public Sach(string tuaDe, TacGia tacGia, decimal gia)
        {
            TuaDe = tuaDe;
            TacGia = tacGia;
            Gia = gia;
            SoLuongTon = 0;
        }

        public Sach(string tuaDe, TacGia tacGia, decimal gia, int soLuong)
        {
            TuaDe = tuaDe;
            TacGia = tacGia;
            Gia = gia;
            SoLuongTon = soLuong;
        }

        // Methods
        public override string ToString()
        {
            return $"Tựa đề: {TuaDe}, Tác giả: {TacGia.HoTen}, Giá: {Gia}, Số lượng tồn: {SoLuongTon}";
        }
    }
}
