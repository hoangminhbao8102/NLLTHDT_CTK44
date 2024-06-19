using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create root directories
            ThuMuc rootC = new ThuMuc("C:\\Cac_mon");
            ThuMuc rootD = new ThuMuc("D:\\MyWeb");

            // Create subdirectories and files for C:
            ThuMuc toan = new ThuMuc("Toan");
            ThuMuc ly = new ThuMuc("Ly");
            ThuMuc tin = new ThuMuc("Tin");

            ThuMuc baiTap = new ThuMuc("Bai tap");
            ThuMuc lyThuyet = new ThuMuc("LyThuyet");
            ThuMuc thucHanh = new ThuMuc("ThucHanh");

            baiTap.Them(new TapTin("Bai1.txt", 120, "Some content here"));
            baiTap.Them(new TapTin("Bai2.txt", 150, "More content here"));
            lyThuyet.Them(new TapTin("Chuong1", 300, "Chapter content"));
            thucHanh.Them(new TapTin("TH_Word.txt", 200, "Word exercise"));
            thucHanh.Them(new TapTin("TH_Excel.txt", 250, "Excel exercise"));

            toan.Them(baiTap);
            toan.Them(lyThuyet);
            ly.Them(thucHanh);

            rootC.Them(toan);
            rootC.Them(ly);
            rootC.Them(tin);

            // Create subdirectories and files for D:
            ThuMuc images = new ThuMuc("Images");
            ThuMuc html = new ThuMuc("HTML");

            images.Them(new TapTin("Hinh1.jpg", 1000, "Hinh 1"));
            images.Them(new TapTin("Hinh2.gif", 1500, "Hinh 2"));
            images.Them(new TapTin("Hinh3.bmp", 2000, "Hinh 3"));

            html.Them(new TapTin("File1.html", 300, "File 1"));
            html.Them(new TapTin("File2.html", 350, "File 2"));

            rootD.Them(images);
            rootD.Them(html);
            rootD.Them(new TapTin("Index.html", 250, "File Index.html"));

            // Display the contents of root directories
            rootC.HienThiNoiDung();
            rootD.HienThiNoiDung();

            Console.ReadKey();
        }
    }
}
