using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_BaiTapThem_QuanLyTaiKhoanNganHang_
{
    abstract class Account
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Balance { get; protected set; }
        public double InterestRate { get; set; }

        public Account(string accountNumber, string ownerName, DateTime dateCreated, decimal initialBalance, double interestRate)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            DateCreated = dateCreated;
            Balance = initialBalance;
            InterestRate = interestRate;
        }

        public abstract void ApplyInterest(); // Phương thức trừu tượng để áp dụng lãi suất
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }
}
