using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Khởi tạo hai số phức z và t
            SoPhuc z = new SoPhuc(3.5, -4.2);
            SoPhuc t = new SoPhuc(1.75, 2.3);

            // Xuất hai số phức
            Console.WriteLine("Số phức z: " + z);
            Console.WriteLine("Số phức t: " + t);

            // Mô-đun của hai số phức
            Console.WriteLine("Mô-đun của z: " + z.TinhModun());
            Console.WriteLine("Mô-đun của t: " + t.TinhModun());

            // Liên hợp của hai số phức
            Console.WriteLine("Liên hợp của z: " + z.LienHop());
            Console.WriteLine("Liên hợp của t: " + t.LienHop());

            // Các phép tính và liên hợp của kết quả
            SoPhuc tong = z.Cong(t);
            SoPhuc hieu = z.Tru(t);
            SoPhuc tich = z.Nhan(t);
            SoPhuc thuong = z.Chia(t);

            Console.WriteLine("Tổng của z và t: " + tong + " và liên hợp: " + tong.LienHop());
            Console.WriteLine("Hiệu của z và t: " + hieu + " và liên hợp: " + hieu.LienHop());
            Console.WriteLine("Tích của z và t: " + tich + " và liên hợp: " + tich.LienHop());
            Console.WriteLine("Thương của z và t: " + thuong + " và liên hợp: " + thuong.LienHop());

            // Kiểm tra các tính chất
            Console.WriteLine("z là số không? " + z.LaSoKhong());
            Console.WriteLine("t là số thuần ảo? " + t.LaSoThuanAo());
            Console.WriteLine("z là số thực? " + z.LaSoThuc());

            // Kiểm tra bằng nhau
            Console.WriteLine("z và t có bằng nhau không? " + z.Equals(t));

            // Nhập và xử lý mảng số phức
            List<SoPhuc> mangSoPhuc = new List<SoPhuc>();
            Console.WriteLine("Nhập số lượng số phức: ");
            int soLuong = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"Nhập phần thực và ảo cho số phức thứ {i + 1}: ");
                double thuc = double.Parse(Console.ReadLine());
                double ao = double.Parse(Console.ReadLine());
                mangSoPhuc.Add(new SoPhuc(thuc, ao));
            }

            // Xuất mảng số phức
            Console.WriteLine("Các số phức trong mảng:");
            foreach (var sp in mangSoPhuc)
            {
                Console.WriteLine(sp);
            }

            // Tính tổng mảng số phức
            SoPhuc tongMang = new SoPhuc();
            foreach (var sp in mangSoPhuc)
            {
                tongMang = tongMang.Cong(sp);
            }
            Console.WriteLine("Tổng các số phức trong mảng: " + tongMang);

            // Tạo mảng liên hợp
            List<SoPhuc> mangLienHop = new List<SoPhuc>();
            foreach (var sp in mangSoPhuc)
            {
                mangLienHop.Add(sp.LienHop());
            }
            Console.WriteLine("Mảng các số phức liên hợp:");
            foreach (var sp in mangLienHop)
            {
                Console.WriteLine(sp);
            }

            Console.ReadKey();
        }
    }
}
