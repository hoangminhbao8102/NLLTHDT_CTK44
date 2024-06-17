using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_BaiTapThem_QuanLyTaiKhoanNganHang_
{
    class Bank
    {
        private List<Account> accounts = new List<Account>();
        private List<Transaction> transactions = new List<Transaction>(); // Giả sử danh sách các giao dịch

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        // Phương thức giả định để thêm giao dịch hoặc xử lý các giao dịch khác
        public void ProcessTransactions()
        {
            foreach (var account in accounts)
            {
                account.ApplyInterest();
                // Thực hiện các hành động khác tùy thuộc vào loại giao dịch
            }
        }

        //c.Mở một tài khoản mới cho khách hàng có tên(tenKh) cho trước.
        public void OpenAccount(string ownerName, string accountNumber, AccountType type)
        {
            switch (type)
            {
                case AccountType.Checking:
                    accounts.Add(new CheckingAccount(accountNumber, ownerName, DateTime.Now, 0, 0.5));
                    break;
                case AccountType.Savings:
                    accounts.Add(new SavingsAccount(accountNumber, ownerName, DateTime.Now, 0, 0.5, 12, "USD"));
                    break;
                case AccountType.Loan:
                    accounts.Add(new LoanAccount(accountNumber, ownerName, DateTime.Now, 0, 5.0, DateTime.Now.AddYears(5)));
                    break;
            }
        }

        //d.Tìm tài khoản theo mã số (maTk) cho trước.
        public Account GetAccount(string accountNumber)
        {
            return accounts.Find(acc => acc.AccountNumber == accountNumber);
        }

        //e.Tìm tất cả tài khoản do khách hàng có mã (maKh) cho trước.
        public List<Account> FindAccountsByOwner(string ownerName)
        {
            return accounts.Where(acc => acc.OwnerName == ownerName).ToList();
        }

        //f.Tìm tất cả các tài khoản vay được lập cách đây ít nhất Y năm.
        public List<LoanAccount> FindOldLoanAccounts(int years)
        {
            DateTime cutoffDate = DateTime.Now.AddYears(-years);
            return accounts.OfType<LoanAccount>().Where(acc => acc.DateCreated <= cutoffDate).ToList();
        }

        //g.Nạp một số tiền (soTien) vào tài khoản (maTk) cho trước.
        public void Deposit(string accountNumber, decimal amount)
        {
            Account account = GetAccount(accountNumber);
            if (account != null)
            {
                // Assuming we have a method to handle deposits directly in the Account class or subclasses
                account.Deposit(amount);
            }
        }

        //h.Rút một số tiền từ tài khoản tiết kiệm hoặc tài khoản ATM
        public void Withdraw(string accountNumber, decimal amount)
        {
            Account account = GetAccount(accountNumber);
            if (account != null && (account is SavingsAccount || account is CheckingAccount))
            {
                account.Withdraw(amount);
            }
        }

        //i. Xem số dư (hoặc dư nợ) của mọi tài khoản
        public List<decimal> GetAllAccountBalances()
        {
            return accounts.Select(acc => acc.Balance).ToList();
        }

        //j.Xem số dư(hoặc dư nợ) của mọi tài khoản do khách hàng có mã(maKh) sở hữu.
        public List<decimal> GetBalancesByOwner(string ownerName)
        {
            return accounts.Where(acc => acc.OwnerName == ownerName).Select(acc => acc.Balance).ToList();
        }

        //k.Tính số dư (hoặc dư nợ) mới cho tất cả các tài khoản.
        public void UpdateAllBalances()
        {
            foreach (var account in accounts)
            {
                account.ApplyInterest();
            }
        }

        //l.Chuyển một số tiền(soTien) từ tài khoản thanh toán sang tài khoản khác.
        public void Transfer(string fromAccountNumber, string toAccountNumber, decimal amount)
        {
            Account fromAccount = GetAccount(fromAccountNumber);
            Account toAccount = GetAccount(toAccountNumber);
            if (fromAccount != null && toAccount != null)
            {
                fromAccount.Withdraw(amount);
                toAccount.Deposit(amount);
            }
        }

        //m.Tất toán(hủy tài khoản) một tài khoản.
        public void CloseAccount(string accountNumber)
        {
            Account account = GetAccount(accountNumber);
            if (account != null)
            {
                accounts.Remove(account);
            }
        }

        //n.Liệt kê các giao dịch chuyển khoản trong ngày
        public List<Transaction> ListTodayTransactions()
        {
            DateTime today = DateTime.Today;
            // Giả sử có một cơ sở dữ liệu giao dịch, ta cần phương thức lấy giao dịch từ ngày hôm nay
            return transactions.Where(tr => tr.Date == today).ToList();
        }

        //o.Tìm những tài khoản không thực hiện bất kỳ giao dịch nào trong ngày.
        public List<Account> GetInactiveAccountsToday()
        {
            var todayTransactions = ListTodayTransactions();
            var activeAccounts = todayTransactions.Select(tr => tr.AccountNumber).Distinct();
            return accounts.Where(acc => !activeAccounts.Contains(acc.AccountNumber)).ToList();
        }

        //p.Hiển thị thông tin chi tiết tất cả các giao dịch.
        public List<Transaction> GetAllTransactions()
        {
            return transactions;
        }

        //q.Cho biết thông tin những tài khoản tiết vay đã được tất toán trong ngày.
        public List<LoanAccount> GetClosedLoanAccountsToday()
        {
            DateTime today = DateTime.Today;
            return transactions
                .Where(tr => tr.TransactionType == TransactionType.CloseAccount && tr.Date.Date == today && tr.Account is LoanAccount)
                .Select(tr => tr.Account as LoanAccount)
                .ToList();
        }

        //r.Tìm tài khoản vay với số tiền lớn nhất.
        public Account GetLargestLoanAccount()
        {
            return accounts.OfType<LoanAccount>().OrderByDescending(acc => acc.Balance).FirstOrDefault();
        }

        //s.Tìm tài khoản thực hiện nhiều giao dịch nhất.
        public Account GetMostActiveAccount()
        {
            var mostActive = transactions.GroupBy(tr => tr.AccountNumber)
                                         .OrderByDescending(g => g.Count())
                                         .FirstOrDefault()?.Key;
            return GetAccount(mostActive);
        }

        // t. Tính tổng số tiền được chuyển khoản giữa các tài khoản.
        public decimal CalculateTotalTransferredAmount()
        {
            return transactions
                .Where(tr => tr.TransactionType == TransactionType.Transfer)
                .Sum(tr => tr.Amount);
        }

        // u. Tìm tài khoản tiết kiệm sử dụng đơn vị tiền tệ USD.
        public List<SavingsAccount> FindSavingsAccountsInUSD()
        {
            return accounts.OfType<SavingsAccount>()
                .Where(acc => acc.Currency == "USD")
                .ToList();
        }

        // v. Tính lãi suất định kỳ (vào cuối tháng) cho các tài khoản vay và tài khoản thanh toán.
        public void ApplyMonthlyInterest()
        {
            foreach (var account in accounts.OfType<LoanAccount>())
            {
                account.ApplyInterest();
            }

            foreach (var account in accounts.OfType<CheckingAccount>())
            {
                account.ApplyInterest();
            }
        }

        // w. Tính tổng số tiền mà ngân hàng cho vay.
        public decimal CalculateTotalLoans()
        {
            return accounts.OfType<LoanAccount>()
                .Sum(acc => acc.Balance);
        }

        // x. Tính chênh lệch giữa số tiền mà ngân hàng cho vay và tổng số tiền khách hàng gửi vào.
        public decimal CalculateNetExposure()
        {
            decimal totalLoans = CalculateTotalLoans();
            decimal totalDeposits = accounts.OfType<SavingsAccount>().Sum(acc => acc.Balance);
            return totalLoans - totalDeposits;
        }

        // y. Cho biết loại giao dịch nào được thực hiện nhiều nhất.
        public TransactionType GetMostFrequentTransactionType()
        {
            return transactions.GroupBy(tr => tr.TransactionType)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();
        }

        // z. Liệt kê tên các nhân viên lập tài khoản cho khách hàng có mã (maKh).
        public List<string> ListEmployeeNamesForCustomerAccounts(string customerName)
        {
            return transactions
                .Where(tr => tr.TransactionType == TransactionType.OpenAccount && tr.Account.OwnerName == customerName)
                .Select(tr => tr.EmployeeName)
                .Distinct()
                .ToList();
        }
    }
}
