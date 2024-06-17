using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_BaiTapThem_QuanLyTaiKhoanNganHang_
{
    class Transaction
    {
        public Account Account { get; set; }
        public DateTime Date { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public TransactionType TransactionType { get; set; }
        public string EmployeeName { get; set; } // Tên nhân viên thực hiện giao dịch
    }
}
