using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;

namespace QuanLyDoiTuongHinhHoc
{
    class DanhSachHinhHoc
    {
        List<HinhHoc> collection = new List<HinhHoc>();
        public void Them(HinhHoc hh)
        {
            collection.Add(hh);
        }

        public HinhHoc LayPhanTuCuoi()
        {
            if (collection.Count > 0)
            {
                return collection[collection.Count - 1];
            }
            return null;
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
            {
                s += "\n" + item;
            }
            return s;
        }
        float TimDienTichHinhVuongLonNhat()
        {
            float max = -1;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    float dt = ((HinhVuong)item).TinhDT();
                    if (dt > max)
                    {
                        max = dt;
                    }
                }
            }
            return max;
        }
        public DanhSachHinhHoc TimHinhVuongCoDTLonNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimDienTichHinhVuongLonNhat();
            foreach (var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhDT() == max)
                {
                    kq.Them(item);
                }
            }
            return kq;
        }
        float TimDienTichLonNhat()
        {
            float max = -1;
            foreach (var item in collection)
            {
                float dt = item.TinhDT();
                if (dt > max)
                {
                    max = dt;
                }
            }
            return max;
        }
        public DanhSachHinhHoc TimHinhCoDTLonNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimDienTichLonNhat();
            foreach (var item in collection)
            {
                if (item.TinhDT() == max)
                {
                    kq.Them(item);
                }
            }
            return kq;
        }
        //3. Tạo tập tin dữ liệu data.txt như sau và viết phương thức NhapTuFile:
        //HT 5
        //HV 7
        //HCN 1 5
        //HT 8
        //HV 9
        //HCN 7 5
        //…
        public void NhapTuFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split();
                if (parts[0] == "HT")
                {
                    float radius = float.Parse(parts[1]);
                    Them(new HinhTron(radius));
                }
                else if (parts[0] == "HV")
                {
                    float side = float.Parse(parts[1]);
                    Them(new HinhVuong(side));
                }
                else if (parts[0] == "HCN")
                {
                    float length = float.Parse(parts[1]);
                    float width = float.Parse(parts[2]);
                    Them(new HinhChuNhat(length, width));
                }
            }
        }
        //4. Tìm tất cả hình vuông có diện tích, chu vi là x
        public DanhSachHinhHoc TimHinhVuongCoDienTichVaChuVi(float dt, float cv)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhDT() == dt && ((HinhVuong)item).TinhCV() == cv)
                {
                    kq.Them(item);
                }
            }
            return kq;
        }
        //5. Tìm tất cả hình vuông có diện tích, chu vi nhỏ nhất
        public DanhSachHinhHoc TimHinhVuongCoDTVaCVNhoNhat()
        {
            float minDT = float.MaxValue;
            float minCV = float.MaxValue;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    float dt = ((HinhVuong)item).TinhDT();
                    float cv = ((HinhVuong)item).TinhCV();
                    if (dt < minDT)
                    {
                        minDT = dt;
                    }
                    if (cv < minCV)
                    {
                        minCV = cv;
                    }
                }
            }
            return TimHinhVuongCoDienTichVaChuVi(minDT, minCV);
        }
        //6. Sắp sếp hình vuông theo chiều tăng, giảm của diện tích
        public void SapXepHinhVuongTheoDienTich(bool tangDan = true)
        {
            if (tangDan)
            {
                collection.Sort((a, b) => (a is HinhVuong && b is HinhVuong) ? ((HinhVuong)a).TinhDT().CompareTo(((HinhVuong)b).TinhDT()) : 0);
            }
            else
            {
                collection.Sort((a, b) => (a is HinhVuong && b is HinhVuong) ? ((HinhVuong)b).TinhDT().CompareTo(((HinhVuong)a).TinhDT()) : 0);
            }
        }
        //7. Tìm hình vuông có cạnh nhỏ nhất, lớn nhất
        public HinhVuong TimHinhVuongCoCanhNhoNhat()
        {
            HinhVuong min = null;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    if (min == null || ((HinhVuong)item).canh < min.canh)
                    {
                        min = (HinhVuong)item;
                    }
                }
            }
            return min;
        }

        public HinhVuong TimHinhVuongCoCanhLonNhat()
        {
            HinhVuong max = null;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    if (max == null || ((HinhVuong)item).canh > max.canh)
                    {
                        max = (HinhVuong)item;
                    }
                }
            }
            return max;
        }
        //8. Tính tổng diện tích, chu vi hình vuông
        public float TongDienTichHinhVuong()
        {
            float sum = 0;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    sum += ((HinhVuong)item).TinhDT();
                }
            }
            return sum;
        }

        public float TongChuViHinhVuong()
        {
            float sum = 0;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    sum += ((HinhVuong)item).TinhCV();
                }
            }
            return sum;
        }
        //9. Đếm số lượng hình vuông
        public int DemSoLuongHinhVuong()
        {
            int count = 0;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    count++;
                }
            }
            return count;
        }

        //10. Làm tương tự các câu 4,5,6,7,8,9 cho các hình tròn, hình chữ nhật
        //10HTa. Tìm tất cả hình tròn có diện tích, chu vi là x
        public DanhSachHinhHoc TimHinhTronCoDienTichVaChuVi(float dt, float cv)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is HinhTron && ((HinhTron)item).TinhDT() == dt && ((HinhTron)item).TinhCV() == cv)
                {
                    kq.Them(item);
                }
            }
            return kq;
        }
        //10HTb. Tìm tất cả hình tròn có diện tích, chu vi nhỏ nhất
        public DanhSachHinhHoc TimHinhTronCoDTVaCVNhoNhat()
        {
            float minDT = float.MaxValue;
            float minCV = float.MaxValue;
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    float dt = ((HinhTron)item).TinhDT();
                    float cv = ((HinhTron)item).TinhCV();
                    if (dt < minDT)
                    {
                        minDT = dt;
                    }
                    if (cv < minCV)
                    {
                        minCV = cv;
                    }
                }
            }
            return TimHinhTronCoDienTichVaChuVi(minDT, minCV);
        }
        //10HTc. Sắp sếp hình tròn theo chiều tăng, giảm của diện tích
        public void SapXepHinhTronTheoDienTich(bool tangDan = true)
        {
            if (tangDan)
            {
                collection.Sort((a, b) => (a is HinhTron && b is HinhTron) ? ((HinhTron)a).TinhDT().CompareTo(((HinhTron)b).TinhDT()) : 0);
            }
            else
            {
                collection.Sort((a, b) => (a is HinhTron && b is HinhTron) ? ((HinhTron)b).TinhDT().CompareTo(((HinhTron)a).TinhDT()) : 0);
            }
        }
        //10HTd. Tìm hình tròn có bán kính nhỏ nhất, lớn nhất
        public HinhTron TimHinhTronCoBanKinhNhoNhat()
        {
            HinhTron min = null;
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    if (min == null || ((HinhTron)item).banKinh < min.banKinh)
                    {
                        min = (HinhTron)item;
                    }
                }
            }
            return min;
        }

        public HinhTron TimHinhTronCoBanKinhLonNhat()
        {
            HinhTron max = null;
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    if (max == null || ((HinhTron)item).banKinh > max.banKinh)
                    {
                        max = (HinhTron)item;
                    }
                }
            }
            return max;
        }
        //10HTe. Tính tổng diện tích, chu vi hình tròn
        public float TongDienTichHinhTron()
        {
            float sum = 0;
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    sum += ((HinhTron)item).TinhDT();
                }
            }
            return sum;
        }

        public float TongChuViHinhTron()
        {
            float sum = 0;
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    sum += ((HinhTron)item).TinhCV();
                }
            }
            return sum;
        }
        //10HTf. Đếm số lượng hình tròn
        public int DemSoLuongHinhTron()
        {
            int count = 0;
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    count++;
                }
            }
            return count;
        }
        //10HCNa. Tìm tất cả hình chữ nhật có diện tích, chu vi là x
        public DanhSachHinhHoc TimHinhChuNhatCoDienTichVaChuVi(float dt, float cv)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDT() == dt && ((HinhChuNhat)item).TinhCV() == cv)
                {
                    kq.Them(item);
                }
            }
            return kq;
        }
        //10HCNb. Tìm tất cả hình chữ nhật có diện tích, chu vi nhỏ nhất
        public DanhSachHinhHoc TimHinhChuNhatCoDTVaCVNhoNhat()
        {
            float minDT = float.MaxValue;
            float minCV = float.MaxValue;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    float dt = ((HinhChuNhat)item).TinhDT();
                    float cv = ((HinhChuNhat)item).TinhCV();
                    if (dt < minDT)
                    {
                        minDT = dt;
                    }
                    if (cv < minCV)
                    {
                        minCV = cv;
                    }
                }
            }
            return TimHinhChuNhatCoDienTichVaChuVi(minDT, minCV);
        }
        //10HCNc. Sắp sếp hình chữ nhật theo chiều tăng, giảm của diện tích
        public void SapXepHinhChuNhatTheoDienTich(bool tangDan = true)
        {
            if (tangDan)
            {
                collection.Sort((a, b) => (a is HinhChuNhat && b is HinhChuNhat) ? ((HinhChuNhat)a).TinhDT().CompareTo(((HinhChuNhat)b).TinhDT()) : 0);
            }
            else
            {
                collection.Sort((a, b) => (a is HinhChuNhat && b is HinhChuNhat) ? ((HinhChuNhat)b).TinhDT().CompareTo(((HinhChuNhat)a).TinhDT()) : 0);
            }
        }
        //10HCNd. Tìm hình chữ nhật có chiều dài nhỏ nhất, lớn nhất
        public HinhChuNhat TimHinhChuNhatCoChieuDaiNhoNhat()
        {
            HinhChuNhat min = null;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    if (min == null || ((HinhChuNhat)item).chieuDai < min.chieuDai)
                    {
                        min = (HinhChuNhat)item;
                    }
                }
            }
            return min;
        }

        public HinhChuNhat TimHinhChuNhatCoChieuDaiLonNhat()
        {
            HinhChuNhat max = null;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    if (max == null || ((HinhChuNhat)item).chieuDai > max.chieuDai)
                    {
                        max = (HinhChuNhat)item;
                    }
                }
            }
            return max;
        }
        //10HCNe. Tìm hình chữ nhật có chiều rộng nhỏ nhất, lớn nhất
        public HinhChuNhat TimHinhChuNhatCoChieuRongNhoNhat()
        {
            HinhChuNhat min = null;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    if (min == null || ((HinhChuNhat)item).chieuRong < min.chieuRong)
                    {
                        min = (HinhChuNhat)item;
                    }
                }
            }
            return min;
        }

        public HinhChuNhat TimHinhChuNhatCoChieuRongLonNhat()
        {
            HinhChuNhat max = null;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    if (max == null || ((HinhChuNhat)item).chieuRong > max.chieuRong)
                    {
                        max = (HinhChuNhat)item;
                    }
                }
            }
            return max;
        }
        //10HCNf. Tính tổng diện tích, chu vi hình chữ nhật
        public float TongDienTichHinhChuNhat()
        {
            float sum = 0;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    sum += ((HinhChuNhat)item).TinhDT();
                }
            }
            return sum;
        }

        public float TongChuViHinhChuNhat()
        {
            float sum = 0;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    sum += ((HinhChuNhat)item).TinhCV();
                }
            }
            return sum;
        }
        //10HCNg. Đếm số lượng hình chữ nhật
        public int DemSoLuongHinhChuNhat()
        {
            int count = 0;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    count++;
                }
            }
            return count;
        }
        //11. Sắp xếp danh sách hình vuông theo chiều tăng giảm của chu vi, diện tích
        public void SapXepHinhVuongTheoChuVi(bool tangDan = true)
        {
            if (tangDan)
            {
                collection.Sort((a, b) => (a is HinhVuong && b is HinhVuong) ? ((HinhVuong)a).TinhCV().CompareTo(((HinhVuong)b).TinhCV()) : 0);
            }
            else
            {
                collection.Sort((a, b) => (a is HinhVuong && b is HinhVuong) ? ((HinhVuong)b).TinhCV().CompareTo(((HinhVuong)a).TinhCV()) : 0);
            }
        }
        //12. Sắp xếp danh sách hình tròn theo chiều tăng giảm của chu vi, diện tích
        public void SapXepHinhTronTheoChuVi(bool tangDan = true)
        {
            if (tangDan)
            {
                collection.Sort((a, b) => (a is HinhTron && b is HinhTron) ? ((HinhTron)a).TinhCV().CompareTo(((HinhTron)b).TinhCV()) : 0);
            }
            else
            {
                collection.Sort((a, b) => (a is HinhTron && b is HinhTron) ? ((HinhTron)b).TinhCV().CompareTo(((HinhTron)a).TinhCV()) : 0);
            }
        }
        //13. Sắp xếp danh sách hình chữ nhật theo chiều tăng giảm của chu vi, diện tích
        public void SapXepHinhChuNhatTheoChuVi(bool tangDan = true)
        {
            if (tangDan)
            {
                collection.Sort((a, b) => (a is HinhChuNhat && b is HinhChuNhat) ? ((HinhChuNhat)a).TinhCV().CompareTo(((HinhChuNhat)b).TinhCV()) : 0);
            }
            else
            {
                collection.Sort((a, b) => (a is HinhChuNhat && b is HinhChuNhat) ? ((HinhChuNhat)b).TinhCV().CompareTo(((HinhChuNhat)a).TinhCV()) : 0);
            }
        }
        //14. Tìm các hình có diện tích lớn nhất, nhỏ nhất
        public HinhHoc TimHinhCoDienTichNhoNhat()
        {
            HinhHoc min = null;
            foreach (var item in collection)
            {
                if (min == null || item.TinhDT() < min.TinhDT())
                {
                    min = item;
                }
            }
            return min;
        }

        public HinhHoc TimHinhCoDienTichLonNhat()
        {
            HinhHoc max = null;
            foreach (var item in collection)
            {
                if (max == null || item.TinhDT() > max.TinhDT())
                {
                    max = item;
                }
            }
            return max;
        }
        //15. Tìm các hình có chu vi lớn nhất, nhỏ nhất
        public HinhHoc TimHinhCoChuViNhoNhat()
        {
            HinhHoc min = null;
            foreach (var item in collection)
            {
                if (min == null || item.TinhCV() < min.TinhCV())
                {
                    min = item;
                }
            }
            return min;
        }

        public HinhHoc TimHinhCoChuViLonNhat()
        {
            HinhHoc max = null;
            foreach (var item in collection)
            {
                if (max == null || item.TinhCV() > max.TinhCV())
                {
                    max = item;
                }
            }
            return max;
        }
        //16. Hiển thị tất cả các hình theo chiều tăng, giảm của diện tích
        public void HienThiTheoDienTich(bool tangDan = true)
        {
            if (tangDan)
            {
                collection.Sort((a, b) => a.TinhDT().CompareTo(b.TinhDT()));
            }
            else
            {
                collection.Sort((a, b) => b.TinhDT().CompareTo(a.TinhDT()));
            }
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        //17. Hiển thị tất cả các hình theo chiều tăng, giảm của chu vi
        public void HienThiTheoChuVi(bool tangDan = true)
        {
            if (tangDan)
            {
                collection.Sort((a, b) => a.TinhCV().CompareTo(b.TinhCV()));
            }
            else
            {
                collection.Sort((a, b) => b.TinhCV().CompareTo(a.TinhCV()));
            }
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        //18. Xóa các hình có diện tích nhỏ nhất, lớn nhất
        public void XoaHinhCoDienTichNhoNhat()
        {
            HinhHoc min = TimHinhCoDienTichNhoNhat();
            collection.Remove(min);
        }

        public void XoaHinhCoDienTichLonNhat()
        {
            HinhHoc max = TimHinhCoDienTichLonNhat();
            collection.Remove(max);
        }
        //19. Xóa các hình có chu vi nhỏ nhất, lớn nhất
        public void XoaHinhCoChuViNhoNhat()
        {
            HinhHoc min = TimHinhCoChuViNhoNhat();
            collection.Remove(min);
        }

        public void XoaHinhCoChuViLonNhat()
        {
            HinhHoc max = TimHinhCoChuViLonNhat();
            collection.Remove(max);
        }
        //20. Thêm hình vào vị trí x
        public void ThemHinhTaiViTri(int viTri, HinhHoc hh)
        {
            collection.Insert(viTri, hh);
        }
        //21. Xóa hình tại vị trí x
        public void XoaHinhTaiViTri(int viTri)
        {
            collection.RemoveAt(viTri);
        }
        //22. Tính tổng diện tích, chu vi các hình
        public float TongDienTichTatCaHinh()
        {
            float sum = 0;
            foreach (var item in collection)
            {
                sum += item.TinhDT();
            }
            return sum;
        }

        public float TongChuViTatCaHinh()
        {
            float sum = 0;
            foreach (var item in collection)
            {
                sum += item.TinhCV();
            }
            return sum;
        }
        //23. Tìm kiểu hình có tổng diện tích, chu vi lớn nhất, nhỏ nhất (ví dụ: trong 3 kiểu hình, hình vuông có tổng diện tích lớn nhất)
        public string KieuHinhCoTongDienTichLonNhat()
        {
            float totalDT_HinhVuong = TongDienTichHinhVuong();
            float totalDT_HinhTron = TongDienTichHinhTron();
            float totalDT_HinhChuNhat = TongDienTichHinhChuNhat();

            if (totalDT_HinhVuong >= totalDT_HinhTron && totalDT_HinhVuong >= totalDT_HinhChuNhat)
            {
                return "Hinh Vuong";
            }
            if (totalDT_HinhTron >= totalDT_HinhVuong && totalDT_HinhTron >= totalDT_HinhChuNhat)
            {
                return "Hinh Tron";
            }
            return "Hinh Chu Nhat";
        }

        public string KieuHinhCoTongChuViLonNhat()
        {
            float totalCV_HinhVuong = TongChuViHinhVuong();
            float totalCV_HinhTron = TongChuViHinhTron();
            float totalCV_HinhChuNhat = TongChuViHinhChuNhat();

            if (totalCV_HinhVuong >= totalCV_HinhTron && totalCV_HinhVuong >= totalCV_HinhChuNhat)
            {
                return "Hinh Vuong";
            }
            if (totalCV_HinhTron >= totalCV_HinhVuong && totalCV_HinhTron >= totalCV_HinhChuNhat)
            {
                return "Hinh Tron";
            }
            return "Hinh Chu Nhat";
        }

        public string KieuHinhCoTongDienTichNhoNhat()
        {
            float totalDT_HinhVuong = TongDienTichHinhVuong();
            float totalDT_HinhTron = TongDienTichHinhTron();
            float totalDT_HinhChuNhat = TongDienTichHinhChuNhat();

            if (totalDT_HinhVuong <= totalDT_HinhTron && totalDT_HinhVuong <= totalDT_HinhChuNhat)
            {
                return "Hinh Vuong";
            }
            if (totalDT_HinhTron <= totalDT_HinhVuong && totalDT_HinhTron <= totalDT_HinhChuNhat)
            {
                return "Hinh Tron";
            }
            return "Hinh Chu Nhat";
        }

        public string KieuHinhCoTongChuViNhoNhat()
        {
            float totalCV_HinhVuong = TongChuViHinhVuong();
            float totalCV_HinhTron = TongChuViHinhTron();
            float totalCV_HinhChuNhat = TongChuViHinhChuNhat();

            if (totalCV_HinhVuong <= totalCV_HinhTron && totalCV_HinhVuong <= totalCV_HinhChuNhat)
            {
                return "Hinh Vuong";
            }
            if (totalCV_HinhTron <= totalCV_HinhVuong && totalCV_HinhTron <= totalCV_HinhChuNhat)
            {
                return "Hinh Tron";
            }
            return "Hinh Chu Nhat";
        }
        //24. Ghi danh sách các hình xuống file riêng: hinhtron.txt, hinhvuong.txt, hinhchunhat.txt
        public void GhiDanhSachHinhXuongFile()
        {
            using (StreamWriter sw = new StreamWriter("hinhtron.txt"))
            {
                foreach (var item in collection)
                {
                    if (item is HinhTron)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("hinhvuong.txt"))
            {
                foreach (var item in collection)
                {
                    if (item is HinhVuong)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("hinhchunhat.txt"))
            {
                foreach (var item in collection)
                {
                    if (item is HinhChuNhat)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }
        //25. Xuất kết kết quả ra theo nội dung sau:
        //BẢNG TỔNG HỢP THÔNG TIN
        //1) Tổng số các đối tượng hình học là:....
        //2) Tổng số hình tròn là:....
        //3) Tổng số hình vuông là:....
        //4) Tổng số hình chữ nhật là:....
        //
        //A. Danh sách hình tròn(theo chiều tăng diện tích):
        //1)Bán kính:....Diện tích:....Chu vi:.....
        //2)Bán kính:....Diện tích:....Chu vi:.....
        //
        //B. Danh sách hình vuông:
        //1)Cạnh:....Diện tích:....Chu vi:.....
        //2)Cạnh:....Diện tích:....Chu vi:.....
        public void XuatKetQua()
        {
            Console.WriteLine("BẢNG TỔNG HỢP THÔNG TIN");
            Console.WriteLine("1) Tổng số các đối tượng hình học là: " + collection.Count);
            Console.WriteLine("2) Tổng số hình tròn: " + DemSoLuongHinhTron());
            Console.WriteLine("3) Tổng số hình vuông: " + DemSoLuongHinhVuong());
            Console.WriteLine("4) Tổng số hình chữ nhật: " + DemSoLuongHinhChuNhat());

            Console.WriteLine("A. Danh sách hình tròn (theo chiều tăng diện tích):");
            SapXepHinhTronTheoDienTich();
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("B. Danh sách hình vuông:");
            SapXepHinhVuongTheoDienTich();
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    Console.WriteLine(item);
                }
            }
        }
        //26. In nội dung của câu 25 xuống file
        public void LuuKetQuaXuongFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("BẢNG TỔNG HỢP THÔNG TIN");
                sw.WriteLine("1) Tổng số các đối tượng hình học là: " + collection.Count);
                sw.WriteLine("2) Tổng số hình tròn: " + DemSoLuongHinhTron());
                sw.WriteLine("3) Tổng số hình vuông: " + DemSoLuongHinhVuong());
                sw.WriteLine("4) Tổng số hình chữ nhật: " + DemSoLuongHinhChuNhat());

                sw.WriteLine("A. Danh sách hình tròn (theo chiều tăng diện tích):");
                SapXepHinhTronTheoDienTich();
                foreach (var item in collection)
                {
                    if (item is HinhTron)
                    {
                        sw.WriteLine(item);
                    }
                }

                sw.WriteLine("B. Danh sách hình vuông:");
                SapXepHinhVuongTheoDienTich();
                foreach (var item in collection)
                {
                    if (item is HinhVuong)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }
        //27. In nội dung của câu 25 ra máy in
        public void InKetQua()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            pd.Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            float yPos = 0f;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            float linesPerPage = ev.MarginBounds.Height / new Font("Arial", 10).GetHeight(ev.Graphics);

            line = "BẢNG TỔNG HỢP THÔNG TIN";
            yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;

            line = "1) Tổng số các đối tượng hình học là: " + collection.Count;
            yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;

            line = "2) Tổng số hình tròn: " + DemSoLuongHinhTron();
            yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;

            line = "3) Tổng số hình vuông: " + DemSoLuongHinhVuong();
            yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;

            line = "4) Tổng số hình chữ nhật: " + DemSoLuongHinhChuNhat();
            yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;

            line = "A. Danh sách hình tròn (theo chiều tăng diện tích):";
            yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;

            SapXepHinhTronTheoDienTich();
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    line = item.ToString();
                    yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
                    count++;
                    if (count >= linesPerPage)
                    {
                        ev.HasMorePages = true;
                        return;
                    }
                }
            }

            line = "B. Danh sách hình vuông:";
            yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;

            SapXepHinhVuongTheoDienTich();
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    line = item.ToString();
                    yPos = topMargin + (count * new Font("Arial", 10).GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, leftMargin, yPos, new StringFormat());
                    count++;
                    if (count >= linesPerPage)
                    {
                        ev.HasMorePages = true;
                        return;
                    }
                }
            }

            ev.HasMorePages = false;
        }
    }
}
