using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_BaiTapThem_QuanLyTaiKhoanNganHang_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Bank bank = new Bank();

            // Thêm một số tài khoản
            bank.OpenAccount("John Doe", "123", AccountType.Checking);
            bank.OpenAccount("Jane Doe", "456", AccountType.Savings);

            // Hiển thị số dư của tất cả tài khoản
            Console.WriteLine("Số dư ban đầu của tất cả tài khoản:");
            foreach (var balance in bank.GetAllAccountBalances())
            {
                Console.WriteLine(balance);
            }

            // Gửi tiền vào tài khoản
            bank.Deposit("123", 500); // Gửi 500 vào tài khoản số 123
            bank.Deposit("456", 1000); // Gửi 1000 vào tài khoản số 456

            // Rút tiền
            bank.Withdraw("123", 200); // Rút 200 từ tài khoản số 123

            // Hiển thị số dư sau các giao dịch
            Console.WriteLine("Số dư của tất cả tài khoản sau các giao dịch:");
            foreach (var balance in bank.GetAllAccountBalances())
            {
                Console.WriteLine(balance);
            }

            // Chuyển tiền
            bank.Transfer("123", "456", 100); // Chuyển 100 từ tài khoản số 123 sang 456

            // Hiển thị số dư cuối cùng
            Console.WriteLine("Số dư cuối cùng của tất cả tài khoản:");
            foreach (var balance in bank.GetAllAccountBalances())
            {
                Console.WriteLine(balance);
            }

            Console.ReadKey();
        }
    }
}
