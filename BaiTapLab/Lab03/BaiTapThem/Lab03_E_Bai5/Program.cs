using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Set a price per credit for tuition calculation
            int giaMotTc = 300000; // Example: 300,000 VND per credit

            // Create instances of SinhVien
            SinhVien[] sinhViens = new SinhVien[3];
            for (int i = 0; i < sinhViens.Length; i++)
            {
                sinhViens[i] = new SinhVien();
                Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");

                // Input student's name and MSSV
                Console.Write("Nhập tên học sinh: ");
                sinhViens[i].HoTen = Console.ReadLine();

                Console.Write("Nhập MSSV của sinh viên: ");
                sinhViens[i].MSSV = Console.ReadLine();

                // Input course information
                bool addMoreCourses;
                do
                {
                    KetQuaThi newKQT = new KetQuaThi();
                    Console.Write("Nhập mã khóa học: ");
                    newKQT.MaMH = Console.ReadLine();

                    Console.Write("Nhập tên khóa học: ");
                    newKQT.TenMH = Console.ReadLine();

                    Console.Write("Nhập tín chỉ khóa học: ");
                    newKQT.SoTC = int.Parse(Console.ReadLine());

                    Console.Write("Nhập điểm khóa học: ");
                    newKQT.Diem = float.Parse(Console.ReadLine());

                    sinhViens[i].DiemThi.Them(newKQT);

                    Console.Write("Thêm các khóa học khác? (Y/N): ");
                    addMoreCourses = Console.ReadLine().Trim().ToLower() == "Y";
                } while (addMoreCourses);
            }

            // Display the information and results for each student
            foreach (var sv in sinhViens)
            {
                Console.WriteLine(sv);
                sv.XuatCacMonHoc();
                Console.WriteLine($"Tổng học phí: {sv.TinhHocPhi(giaMotTc):N0} VNĐ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
