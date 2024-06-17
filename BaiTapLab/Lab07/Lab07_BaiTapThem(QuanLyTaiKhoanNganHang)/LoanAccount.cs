using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_BaiTapThem_QuanLyTaiKhoanNganHang_
{
    class LoanAccount : Account
    {
        public DateTime DueDate { get; set; }

        public LoanAccount(string accountNumber, string ownerName, DateTime dateCreated, decimal loanAmount, double interestRate, DateTime dueDate)
            : base(accountNumber, ownerName, dateCreated, loanAmount, interestRate)
        {
            DueDate = dueDate;
        }

        public override void ApplyInterest()
        {
            Balance += Balance * (decimal)(InterestRate / 100);
        }

        public void MakePayment(decimal amount)
        {
            Balance -= amount;
        }

        public override void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
