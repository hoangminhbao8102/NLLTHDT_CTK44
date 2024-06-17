using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_BaiTapThem_QuanLyTaiKhoanNganHang_
{
    class SavingsAccount : Account
    {
        public int TermMonths { get; set; }
        public string Currency { get; set; }

        public SavingsAccount(string accountNumber, string ownerName, DateTime dateCreated, decimal depositAmount, double interestRate, int termMonths, string currency)
            : base(accountNumber, ownerName, dateCreated, depositAmount, interestRate)
        {
            TermMonths = termMonths;
            Currency = currency;
        }

        public override void ApplyInterest()
        {
            if (DateTime.Now >= DateCreated.AddMonths(TermMonths))
            {
                Balance += Balance * (decimal)(InterestRate / 100);
            }
        }

        public override void Deposit(decimal amount)
        {
            throw new InvalidOperationException("Deposits into savings accounts are not allowed directly.");
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
