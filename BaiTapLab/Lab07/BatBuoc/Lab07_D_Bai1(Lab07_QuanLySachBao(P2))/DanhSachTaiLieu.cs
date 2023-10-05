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
        public List<string> LayDanhSachNhaXuatBan()
        {
            List<string> danhSachNhaXb = new List<string>();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is Sach)
                {
                    string nhaXb = ((Sach)danhSach[i]).NhaXB;
                    if (!danhSachNhaXb.Contains(nhaXb))
                    {
                        danhSachNhaXb.Add(nhaXb);
                    }
                }
            }
            return danhSachNhaXb;
        }

        //h. Tìm những nhà xuất bản có nhiều sách nhất
        public List<string> TimNhieuSachNhat()
        {
            Dictionary<string, int> soSachTheoNhaXb = new Dictionary<string, int>();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is Sach)
                {
                    string nhaXb = ((Sach)danhSach[i]).NhaXB;
                    if (soSachTheoNhaXb.ContainsKey(nhaXb))
                    {
                        soSachTheoNhaXb[nhaXb]++;
                    }
                    else
                    {
                        soSachTheoNhaXb[nhaXb] = 1;
                    }
                }
            }
            int maxSoSach = soSachTheoNhaXb.Values.Max();
            List<string> nhieuSachNhat = new List<string>();
            foreach (KeyValuePair<string, int> pair in soSachTheoNhaXb)
            {
                if (pair.Value == maxSoSach)
                {
                    nhieuSachNhat.Add(pair.Key);
                }
            }
            return nhieuSachNhat;
        }

        //i. Liệt kê danh sách các nhà xuất bản và số sách đã xuất bản
        public Dictionary<string, int> LietKeSoSachTheoNhaXuatBan()
        {
            Dictionary<string, int> soSachTheoNhaXb = new Dictionary<string, int>();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is Sach)
                {
                    string nhaXb = ((Sach)danhSach[i]).NhaXB;
                    if (soSachTheoNhaXb.ContainsKey(nhaXb))
                    {
                        soSachTheoNhaXb[nhaXb]++;
                    }
                    else
                    {
                        soSachTheoNhaXb[nhaXb] = 1;
                    }
                }
            }
            return soSachTheoNhaXb;
        }

        //j.Sắp xếp sách và báo khoa học giảm dần theo năm xuất bản
        public void SapXepSachVaBaoKhoaHocGiamTheoNamXuatBan()
        {
            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if ((danhSach[i] is Sach && danhSach[j] is Sach) || (danhSach[i] is BaoKhoaHoc && danhSach[j] is BaoKhoaHoc))
                    {
                        if (danhSach[i].NamXB < danhSach[j].NamXB)
                        {
                            TaiLieu temp = danhSach[i];
                            danhSach[i] = danhSach[j];
                            danhSach[j] = temp;
                        }
                    }
                }
            }
        }

        //k. Sắp danh sách tài liệu tăng dần theo nhan đề (xếp theo thứ tự abc)
        public void SapXepDanhSachTangDanTheoNhanDe()
        {
            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (string.Compare(danhSach[i].NhanDe, danhSach[j].NhanDe) > 0)
                    {
                        TaiLieu temp = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = temp;
                    }
                }
            }
        }

        //l.Tìm những bài báo được đăng tại hội nghị(hoiNghi) và được xuất bản năm(nam)
        public List<BaoKhoaHoc> TimBaiBaoTheoHoiNghiVaNam(string hoiNghi, int nam)
        {
            List<BaoKhoaHoc> ketQua = new List<BaoKhoaHoc>();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is BaoKhoaHoc)
                {
                    BaoKhoaHoc baiBao = (BaoKhoaHoc)danhSach[i];
                    if (baiBao.HoiNghi == hoiNghi && baiBao.NamXB == nam)
                    {
                        ketQua.Add(baiBao);
                    }
                }
            }
            return ketQua;
        }

        //m.Tìm những bài báo khoa học chỉ có đúng một tác giả
        public List<BaoKhoaHoc> TimBaiBaoKhoaHocMotTacGia()
        {
            List<BaoKhoaHoc> ketQua = new List<BaoKhoaHoc>();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is BaoKhoaHoc)
                {
                    BaoKhoaHoc baiBao = (BaoKhoaHoc)danhSach[i];
                    if (baiBao.TacGia.Count() == 1)
                    {
                        ketQua.Add(baiBao);
                    }
                }
            }
            return ketQua;
        }

        //n.Tìm những bài báo khoa học có nhiều tác giả nhất.
        public List<BaoKhoaHoc> TimBaiBaoKhoaHocNhieuTacGiaNhat()
        {
            List<BaoKhoaHoc> ketQua = new List<BaoKhoaHoc>();
            int maxSoTacGia = 0;
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is BaoKhoaHoc)
                {
                    BaoKhoaHoc baiBao = (BaoKhoaHoc)danhSach[i];
                    if (baiBao.TacGia.Count() > maxSoTacGia)
                    {
                        maxSoTacGia = baiBao.TacGia.Count();
                        ketQua.Clear();
                        ketQua.Add(baiBao);
                    }
                    else if (baiBao.TacGia.Count() == maxSoTacGia)
                    {
                        ketQua.Add(baiBao);
                    }
                }
            }
            return ketQua;
        }

        //o.Liệt kê danh sách các bài báo khoa học có sự tham gia của tác giả(tacGia)
        public List<BaoKhoaHoc> LietKeBaiBaoKhoaHocTheoTacGia(string tacGia)
        {
            List<BaoKhoaHoc> ketQua = new List<BaoKhoaHoc>();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is BaoKhoaHoc)
                {
                    BaoKhoaHoc baiBao = (BaoKhoaHoc)danhSach[i];
                    if (baiBao.TacGia.Contains(tacGia))
                    {
                        ketQua.Add(baiBao);
                    }
                }
            }
            return ketQua;
        }

        //p.Liệt kê danh sách các bài báo khoa học giảm dần theo năm xuất bản
        public void SapXepBaiBaoKhoaHocGiamTheoNamXuatBan()
        {
            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = 0; j < soLuong; j++)
                {
                    if (danhSach[i] is BaoKhoaHoc && danhSach[j] is BaoKhoaHoc)
                    {
                        if (((BaoKhoaHoc)danhSach[i]).NamXB < ((BaoKhoaHoc)danhSach[j]).NamXB)
                        {
                            TaiLieu temp = danhSach[i];
                            danhSach[i] = danhSach[j];
                            danhSach[j] = temp;
                        }
                    }
                }
            }
        }

        //q.Liệt kê danh sách các bài báo khoa học có sự tham gia của tác giả (tacGia), sắp theo ABC
        public List<BaoKhoaHoc> LietKeBaiBaoKhoaHocTheoTacGiaSapTheoABC(string tacGia)
        {
            List<BaoKhoaHoc> ketQua = new List<BaoKhoaHoc>();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is BaoKhoaHoc)
                {
                    BaoKhoaHoc baiBao = (BaoKhoaHoc)danhSach[i];
                    if (baiBao.TacGia.Contains(tacGia))
                    {
                        ketQua.Add(baiBao);
                    }
                }
            }
            ketQua.Sort((x, y) => string.Compare(x.NhanDe, y.NhanDe));
            return ketQua;
        }

        //r. Xóa tất cả những tài liệu có sự tham gia của tác giả (tacGia) cho trước.
        public void XoaTaiLieuTheoTacGia(string tacGia)
        {
            List<TaiLieu> danhSachTam = new List<TaiLieu>(danhSach);
            foreach (TaiLieu taiLieu in danhSach)
            {
                if (taiLieu is BaoKhoaHoc)
                {
                    BaoKhoaHoc baiBao = (BaoKhoaHoc)taiLieu;
                    if (baiBao.TacGia.Contains(tacGia))
                    {
                        danhSachTam.Remove(taiLieu);
                    }
                }
            }
            danhSach = danhSachTam.ToArray();
            soLuong = danhSach.Length;
        }

        //s.Tìm những tài liệu cũ nhất (đã được xuất bản cách đây lâu nhất).
        public TaiLieu TimTaiLieuCuNhat()
        {
            TaiLieu taiLieuCuNhat = null;
            foreach (TaiLieu taiLieu in danhSach)
            {
                if (taiLieuCuNhat == null || taiLieu.NamXB < taiLieuCuNhat.NamXB)
                {
                    taiLieuCuNhat = taiLieu;
                }
            }
            return taiLieuCuNhat;
        }

        //t.Cho biết tên của những người làm luận văn(tác giả của các luận văn).
        public List<string> TimTacGiaLuanVan()
        {
            List<string> tacGiaLuanVan = new List<string>();
            foreach (TaiLieu taiLieu in danhSach)
            {
                if (taiLieu is LuanVan)
                {
                    LuanVan luanVan = (LuanVan)taiLieu;
                    string[] tacGiaArray = new string[luanVan.TacGia.Length];
                    for (int i = 0; i < luanVan.TacGia.Length; i++)
                    {
                        tacGiaArray[i] = luanVan.TacGia[i].ToString();
                    }
                    foreach (string tacGia in tacGiaArray)
                    {
                        if (!tacGiaLuanVan.Contains(tacGia))
                        {
                            tacGiaLuanVan.Add(tacGia);
                        }
                    }
                }
            }
            return tacGiaLuanVan;
        }

        //u.Cho biết tên của các tác giả vừa viết sách, vừa có đăng báo khoa học và làm luận văn.
        public List<string> TimTacGiaVietSachBaoKhoaHocLuanVan()
        {
            List<string> tacGiaVietSachBaoKhoaHocLuanVan = new List<string>();
            foreach (TaiLieu taiLieu in danhSach)
            {
                if (taiLieu is Sach && taiLieu is BaoKhoaHoc && taiLieu is LuanVan)
                {
                    Sach sach = (Sach)taiLieu;
                    BaoKhoaHoc baoKhoaHoc = (BaoKhoaHoc)taiLieu;
                    LuanVan luanVan = (LuanVan)taiLieu;
                    string[] tacGiaArray = sach.TacGia.ToCharArray().Select(c => c.ToString()).ToArray();
                    foreach (string tacGia in tacGiaArray)
                    {
                        if (baoKhoaHoc.TacGia.Contains(tacGia) && luanVan.TacGia.Contains(tacGia))
                        {
                            tacGiaVietSachBaoKhoaHocLuanVan.Add(tacGia);
                        }
                    }
                }
            }
            return tacGiaVietSachBaoKhoaHocLuanVan;
        }

        //v.Liệt kê danh sách tất cả các tác giả của các tài liệu, nếu trùng tên thì chỉ lấy một.
        public List<string> LietKeTacGia()
        {
            List<string> danhSachTacGia = new List<string>();
            foreach (TaiLieu taiLieu in danhSach)
            {
                foreach (char tacGiaChar in taiLieu.TacGia)
                {
                    string tacGia = tacGiaChar.ToString();
                    if (!danhSachTacGia.Contains(tacGia))
                    {
                        danhSachTacGia.Add(tacGia);
                    }
                }
            }
            return danhSachTacGia;
        }

        //w.Với mỗi tác giả, liệt kê số lượng tài liệu mỗi loại.
        public Dictionary<string, int> LietKeSoLuongTaiLieuTheoLoai()
        {
            Dictionary<string, int> soLuongTaiLieuTheoLoai = new Dictionary<string, int>();
            foreach (TaiLieu taiLieu in danhSach)
            {
                if (taiLieu is Sach)
                {
                    if (soLuongTaiLieuTheoLoai.ContainsKey("Sach"))
                    {
                        soLuongTaiLieuTheoLoai["Sach"]++;
                    }
                    else
                    {
                        soLuongTaiLieuTheoLoai["Sach"] = 1;
                    }
                }
                else if (taiLieu is BaoKhoaHoc)
                {
                    if (soLuongTaiLieuTheoLoai.ContainsKey("BaiBaoKhoaHoc"))
                    {
                        soLuongTaiLieuTheoLoai["BaiBaoKhoaHoc"]++;
                    }
                    else
                    {
                        soLuongTaiLieuTheoLoai["BaiBaoKhoaHoc"] = 1;
                    }
                }
                else if (taiLieu is LuanVan)
                {
                    if (soLuongTaiLieuTheoLoai.ContainsKey("LuanVan"))
                    {
                        soLuongTaiLieuTheoLoai["LuanVan"]++;
                    }
                    else
                    {
                        soLuongTaiLieuTheoLoai["LuanVan"] = 1;
                    }
                }
            }
            return soLuongTaiLieuTheoLoai;
        }

        //x.Tìm những tác giả có viết báo khoa học, làm luận văn nhưng không viết sách
        public List<string> TimTacGiaBaoKhoaHocLuanVanKhongVietSach()
        {
            List<string> tacGiaBaoKhoaHocLuanVanKhongVietSach = new List<string>();
            List<string> tacGiaVietSach = new List<string>(); // Khai báo và khởi tạo danh sách tacGiaVietSach

            foreach (TaiLieu taiLieu in danhSach)
            {
                if (taiLieu is BaoKhoaHoc && taiLieu is LuanVan && !(taiLieu is Sach))
                {
                    BaoKhoaHoc baoKhoaHoc = (BaoKhoaHoc)taiLieu;
                    LuanVan luanVan = (LuanVan)taiLieu;
                    foreach (char tacGiaChar in baoKhoaHoc.TacGia)
                    {
                        string tacGia = tacGiaChar.ToString();
                        if (luanVan.TacGia.Contains(tacGia) && !tacGiaVietSach.Contains(tacGia))
                        {
                            tacGiaBaoKhoaHocLuanVanKhongVietSach.Add(tacGia);
                        }
                    }
                }
            }
            return tacGiaBaoKhoaHocLuanVanKhongVietSach;
        }

        //y.Tạo lớp Menu cho phép người dùng chọn các chức năng trên.
        //z.Cài đặt hàm xử lý menu.
    }
}
