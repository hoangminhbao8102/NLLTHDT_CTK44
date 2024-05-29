using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai5
{
    public class TacGia
    {
        // Fields
        private string _email;
        private bool _phai; // Gender; true might represent male and false female
        private string _ten; // Name

        // Properties
        public string Email { get; set; }
        public bool Phai { get; set; }
        public string HoTen { get; set; }

        // Constructors
        public TacGia()
        {
            HoTen = string.Empty;
            Email = string.Empty;
            Phai = false;
        }

        public TacGia(string ten, string email, bool phai)
        {
            HoTen = ten;
            Email = email;
            Phai = phai;
        }

        // Methods
        public override string ToString()
        {
            return $"Tên tác giả: {HoTen}, Email: {Email}, Giới tính: {(Phai ? "Nam" : "Nữ")}";
        }
    }
}
