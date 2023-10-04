using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai1_Lab07_QuanLySachBao_P2__
{
    public class DanhSachTaiLieu
    {
        private TaiLieu[] danhSach;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public TaiLieu this[int index]
        {
            get { return danhSach[index]; }
            set { danhSach[index] = value; }
        }

        public DanhSachTaiLieu()
        {
            danhSach = new TaiLieu[100];
            soLuong = 0;
        }

        public void Them(TaiLieu taiLieu)
        {
            danhSach[soLuong] = taiLieu;
            soLuong++;
        }

        public int TimViTriTaiLieu(string maSoTL)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].MaSo == maSoTL)
                {
                    return i;
                }
            }
            return -1;
        }

        public int TimViTriTaiLieu(TaiLieu taiLieu)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] == taiLieu)
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < soLuong; i++)
            {
                result += danhSach[i].ToString() + "\n";
            }
            return result;
        }

        //a.Xóa một tài liệu tại vị trí(viTri) cho trước khỏi danh sách tài liệu
        public void XoaTaiLieu(int viTri)
        {
            if (viTri >= 0 && viTri < soLuong)
            {
                for (int i = viTri; i < soLuong - 1; i++)
                {
                    danhSach[i] = danhSach[i + 1];
                }
                danhSach[soLuong - 1] = null;
                soLuong--;
            }
        }

        //b.Xóa một tài liệu có mã số cho trước khỏi danh sách tài liệu
        public void XoaTaiLieu(string maSoTL)
        {
            int viTri = TimViTriTaiLieu(maSoTL);
            if (viTri != -1)
            {
                XoaTaiLieu(viTri);
            }
        }

        //c. Xóa một tài liệu cho trước khỏi danh sách tài liệu
        public void XoaTaiLieu(TaiLieu taiLieu)
        {
            int viTri = TimViTriTaiLieu(taiLieu);
            if (viTri != -1)
            {
                XoaTaiLieu(viTri);
            }
        }

        //d. Tìm các tài liệu được viết bởi tác giả (tacGia) cho trước
        public DanhSachTaiLieu TimTaiLieuTheoTacGia(string tacGia)
        {
            DanhSachTaiLieu ketQua = new DanhSachTaiLieu();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].TacGia == tacGia)
                {
                    ketQua.Them(danhSach[i]);
                }
            }
            return ketQua;
        }

        //e. Tìm sách được xuất bản bởi nhà xuất bản (nhaXb) cho trước
        public DanhSachTaiLieu TimSachTheoNhaXuatBan(string nhaXb)
        {
            DanhSachTaiLieu ketQua = new DanhSachTaiLieu();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is Sach && ((Sach)danhSach[i]).NhaXB == nhaXb)
                {
                    ketQua.Them(danhSach[i]);
                }
            }
            return ketQua;
        }

        //f. Xóa các sách được xuất bản bởi nhaXb cách đây ít nhất k năm.
        public void XoaSachTheoNhaXuatBan(string nhaXb, int k)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is Sach && ((Sach)danhSach[i]).NhaXB == nhaXb && ((Sach)danhSach[i]).NamXB <= DateTime.Now.Year - k)
                {
                    XoaTaiLieu(i);
                    i--;
                }
            }
        }

        //g.Lấy danh sách tất cả các nhà xuất bản
        //h. Tìm những nhà xuất bản có nhiều sách nhất
        //i. Liệt kê danh sách các nhà xuất bản và số sách đã xuất bản
        //j.Sắp xếp sách và báo khoa học giảm dần theo năm xuất bản
        //k. Sắp danh sách tài liệu tăng dần theo nhan đề (xếp theo thứ tự abc)
        //l.Tìm những bài báo được đăng tại hội nghị(hoiNghi) và được xuất bản năm(nam)
        //m.Tìm những bài báo khoa học chỉ có đúng một tác giả
        //n.Tìm những bài báo khoa học có nhiều tác giả nhất.
        //o.Liệt kê danh sách các bài báo khoa học có sự tham gia của tác giả(tacGia)
        //p.Liệt kê danh sách các bài báo khoa học giảm dần theo năm xuất bản
        //q.Liệt kê danh sách các bài báo khoa học có sự tham gia của tác giả (tacGia), sắp theo ABC
        //r. Xóa tất cả những tài liệu có sự tham gia của tác giả (tacGia) cho trước.
        //s.Tìm những tài liệu cũ nhất (đã được xuất bản cách đây lâu nhất).
        //t.Cho biết tên của những người làm luận văn(tác giả của các luận văn).
        //u.Cho biết tên của các tác giả vừa viết sách, vừa có đăng báo khoa học và làm luận văn.
        //v.Liệt kê danh sách tất cả các tác giả của các tài liệu, nếu trùng tên thì chỉ lấy một.
        //w.Với mỗi tác giả, liệt kê số lượng tài liệu mỗi loại.
        //x.Tìm những tác giả có viết báo khoa học, làm luận văn nhưng không viết sách
        //y.Tạo lớp Menu cho phép người dùng chọn các chức năng trên.
        //z.Cài đặt hàm xử lý menu.
    }
}
