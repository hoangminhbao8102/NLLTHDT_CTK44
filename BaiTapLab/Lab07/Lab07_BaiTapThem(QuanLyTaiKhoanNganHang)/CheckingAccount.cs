using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_BaiTapThem_QuanLyTaiKhoanNganHang_
{
    class CheckingAccount : Account
    {
        public CheckingAccount(string accountNumber, string ownerName, DateTime dateCreated, decimal initialBalance, double interestRate)
            : base(accountNumber, ownerName, dateCreated, initialBalance, interestRate)
        {
        }

        public override void ApplyInterest()
        {
            // Thông thường, tài khoản thanh toán không có lãi suất, hoặc nếu có, nó sẽ rất thấp.
        }

        public override void Deposit(decimal amount)
        {
            this.Balance += amount; // Cập nhật số dư
        }

        public override void Withdraw(decimal amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }
    }
}
