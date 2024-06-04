using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai1_Lab03_D_Bai5_P2__
{
    public class Sach
    {
        // Fields
        private decimal _gia; // Price
        private int _soLuong; // Quantity
        private List<TacGia> _tacGias; // List of authors
        private string _tuaDe; // Title

        // Properties
        public decimal Gia 
        { 
            get { return _gia; }
            set { _gia = value; } 
        }

        public int SoLuongTon 
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        public List<TacGia> TacGias 
        { 
            get { return _tacGias; } 
            set { _tacGias = value; } 
        }
        
        public string TuaDe 
        {
            get { return _tuaDe; }
            set { _tuaDe = value; }
        }

        // Constructors
        public Sach(string tuaDe, List<TacGia> tacGias, decimal gia)
        {
            TuaDe = tuaDe;
            TacGias = tacGias;
            Gia = gia;
            SoLuongTon = 0;
        }

        public Sach(string tuaDe, List<TacGia> tacGias, decimal gia, int soLuong)
        {
            TuaDe = tuaDe;
            TacGias = tacGias;
            Gia = gia;
            SoLuongTon = soLuong;
        }

        // Methods
        public override string ToString()
        {
            string authorNames = string.Join(", ", TacGias.Select(tg => tg.HoTen).ToArray());
            return $"Tựa đề: {TuaDe}, Tác giả: {authorNames}, Giá: {Gia}, Số lượng tồn: {SoLuongTon}";
        }
    }
}
