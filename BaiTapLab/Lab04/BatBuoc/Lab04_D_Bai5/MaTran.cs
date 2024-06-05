using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai5
{
    public class MaTran
    {
        private int[,] bang;
        private int soHang;
        private int soCot;


        public int SoCot
        {
            get { return soCot; }
        }
        public int SoHang
        {
            get { return soHang; }
        }
        // Indexer để truy cập và thiết lập giá trị của ma trận
        public int this[int row, int co]
        {
            get { return bang[row, co]; }
            set { bang[row, co] = value; }
        }

        public MaTran(int soHang, int soCot)
        {
            this.soHang = soHang;
            this.soCot = soCot;
            bang = new int[soHang, soCot];
        }

        public MaTran(int soHang, int soCot, int phanTu)
        {
            this.soHang = soHang;
            this.soCot = soCot;
            bang = new int[soHang, soCot];

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    bang[i, j] = phanTu;
                }
            }
        }

        // Nhập ngẫu nhiên
        public void NhapNgauNhien()
        {
            Random rng = new Random(); // Tạo đối tượng Random để sinh số ngẫu nhiên
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    bang[i, j] = rng.Next(0, 101); // Sinh số ngẫu nhiên từ 0 đến 100
                }
            }
        }

        // Nhập tay
        public void NhapTay()
        {
            Console.WriteLine("Nhập các phần tử cho ma trận:");
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"Nhập phần tử [{i},{j}]: ");
                    bang[i, j] = int.Parse(Console.ReadLine()); // Đọc và chuyển đổi chuỗi nhập vào thành số nguyên
                }
            }
        }

        // Toán tử cộng hai ma trận
        public static MaTran operator +(MaTran x, MaTran y)
        {
            var result = new MaTran(x.soHang, x.soCot);
            for (int i = 0; i < x.soHang; i++)
            {
                for (int j = 0; j < x.soCot; j++)
                {
                    result[i, j] = x[i, j] + y[i, j];
                }
            }
            return result;
        }

        // Toán tử trừ hai ma trận
        public static MaTran operator -(MaTran x, MaTran y)
        {
            if (x.soHang != y.soHang || x.soCot != y.soCot)
            {
                throw new ArgumentException("Các ma trận phải có cùng kích thước để thực hiện phép trừ.");
            }
            MaTran result = new MaTran(x.soHang, x.soCot);
            for (int i = 0; i < x.soHang; i++)
            {
                for (int j = 0; j < x.soCot; j++)
                {
                    result[i, j] = x[i, j] - y[i, j];
                }
            }
            return result;
        }

        // Toán tử nhân ma trận với ma trận
        public static MaTran operator *(MaTran x, MaTran y)
        {
            var result = new MaTran(x.soHang, y.soCot);
            for (int i = 0; i < x.soHang; i++)
            {
                for (int j = 0; j < y.soCot; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < x.soCot; k++)
                    {
                        result[i, j] += x[i, k] * y[k, j];
                    }
                }
            }
            return result;
        }

        // Toán tử ma trận nghịch đảo
        public static MaTran operator !(MaTran x)
        {
            // Kiểm tra xem ma trận có khả năng nghịch đảo không
            if (x.soHang != x.soCot)
            {
                throw new InvalidOperationException("Ma trận phải là ma trận vuông để có thể nghịch đảo.");
            }

            // Giả định đây là cách tính nghịch đảo (Cần phương pháp thực tế)
            MaTran result = new MaTran(x.soHang, x.soCot);
            for (int i = 0; i < x.soHang; i++)
            {
                result[i, i] = 1; // Đây chỉ là một giả định cho mục đích minh họa
            }
            return result;
        }

        // Toán tử ma trận chuyển vị
        public static MaTran operator ~(MaTran x)
        {
            MaTran result = new MaTran(x.soCot, x.soHang);
            for (int i = 0; i < x.soCot; i++)
            {
                for (int j = 0; j < x.soHang; j++)
                {
                    result[i, j] = x[j, i];
                }
            }
            return result;
        }

        // Thực thiện phương thức ToString để hiển thị ma trận
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    s += bang[i, j] + "\t";
                }
                s += "\n";
            }
            return s;
        }
    }
}
