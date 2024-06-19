using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Giải phương trình bậc nhất
            BacNhat ptBacNhat = new BacNhat(1, -3);
            Console.WriteLine("Phương trình bậc nhất:");
            ptBacNhat.Giai();

            // Giải phương trình bậc hai
            BacHai ptBacHai = new BacHai(1, -3, 2);
            Console.WriteLine("Phương trình bậc hai:");
            ptBacHai.Giai();

            // Giải phương trình bậc ba
            BacBa ptBacBa = new BacBa(1, -6, 11, -6);
            Console.WriteLine("Phương trình bậc ba:");
            ptBacBa.Giai();

            // Giải phương trình trùng phương
            TrungPhuong ptTrungPhuong = new TrungPhuong(1, -10, 9);
            Console.WriteLine("Phương trình trùng phương:");
            ptTrungPhuong.Giai();

            // Giải hệ phương trình tuyến tính bậc nhất 2 ẩn
            HePhuongTrinh hePhuongTrinh = new HePhuongTrinh(1, -2, -3, -2, 1, 9);
            Console.WriteLine("Hệ phương trình tuyến tính 2 ẩn:");
            hePhuongTrinh.Giai();

            Console.ReadKey();
        }
    }
}
