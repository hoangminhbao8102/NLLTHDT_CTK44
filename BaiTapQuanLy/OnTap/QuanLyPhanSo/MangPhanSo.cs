using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    public class MangPhanSo
    {
        private List<PhanSo> _phanSos = new List<PhanSo>();

        public void Nhap()
        {
            Console.Write("Nhập vào chiều dài mảng: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                PhanSo phanSo = new PhanSo();
                phanSo.Nhap();
                _phanSos.Add(phanSo);
            }
        }

        public void Xuat()
        {
            foreach (var phanSo in _phanSos)
            {
                phanSo.Xuat();
            }
        }

        public void Them(PhanSo x)
        {
            _phanSos.Add(x);
        }

        public void NhapTuFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] parts = s.Split('/');
                    int tu = int.Parse(parts[0]);
                    int mau = int.Parse(parts[1]);
                    Them(new PhanSo(tu, mau));
                }
            }
        }

        public PhanSo NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            int tu = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            int mau = int.Parse(Console.ReadLine());
            return new PhanSo(tu, mau);
        }

        public void NhapNgauNhien()
        {
            Console.Write("Nhập vào chiều dài mảng: ");
            int length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                _phanSos.Add(new PhanSo(r.Next(1, 10), r.Next(1, 10)));
            }
        }

        public PhanSo TimMax()
        {
            return _phanSos.Count > 0 ? _phanSos.Max() : null;
        }

        public MangPhanSo TimPhanSoCoMauLa(int x)
        {
            MangPhanSo kq = new MangPhanSo();
            foreach (var phanSo in _phanSos)
            {
                if (phanSo.Mau == x)
                {
                    kq.Them(phanSo);
                }
            }
            return kq;
        }

        public int DemPhanSoAm()
        {
            return _phanSos.Count(ps => ps.Tu < 0);
        }

        public int DemPhanSoDuong()
        {
            return _phanSos.Count(ps => ps.Tu > 0);
        }

        public int DemPhanSoCoTuLa(int x)
        {
            return _phanSos.Count(ps => ps.Tu == x);
        }

        public int DemPhanSoCoMauLa(int x)
        {
            return _phanSos.Count(ps => ps.Mau == x);
        }

        public PhanSo TimPhanSoAmLonNhat()
        {
            return _phanSos.Where(ps => ps.Tu < 0).OrderByDescending(ps => ps.Tu).FirstOrDefault();
        }

        public PhanSo TimPhanSoAmNhoNhat()
        {
            return _phanSos.Where(ps => ps.Tu < 0).OrderBy(ps => ps.Tu).FirstOrDefault();
        }

        public PhanSo TimPhanSoDuongLonNhat()
        {
            return _phanSos.Where(ps => ps.Tu > 0).OrderByDescending(ps => ps.Tu).FirstOrDefault();
        }

        public PhanSo TimPhanSoDuongNhoNhat()
        {
            return _phanSos.Where(ps => ps.Tu > 0).OrderBy(ps => ps.Tu).FirstOrDefault();
        }

        public MangPhanSo TimTatCaPhanSoAm()
        {
            MangPhanSo kq = new MangPhanSo();
            foreach (var phanSo in _phanSos.Where(ps => ps.Tu < 0))
            {
                kq.Them(phanSo);
            }
            return kq;
        }

        public MangPhanSo TimTatCaPhanSoDuong()
        {
            MangPhanSo kq = new MangPhanSo();
            foreach (var phanSo in _phanSos.Where(ps => ps.Tu > 0))
            {
                kq.Them(phanSo);
            }
            return kq;
        }

        public List<int> TimViTriCuaPhanSo(int x)
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < _phanSos.Count; i++)
            {
                if (_phanSos[i].Tu == x)
                {
                    positions.Add(i);
                }
            }
            return positions;
        }

        public List<int> TimViTriCuaPhanSoAmDuong()
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < _phanSos.Count; i++)
            {
                if (_phanSos[i].Tu < 0 || _phanSos[i].Tu > 0)  // Giả sử phân số âm và dương được định nghĩa bởi tử số
                {
                    positions.Add(i);
                }
            }
            return positions;
        }


        public int TinhTongTatCaPhanSoAm()
        {
            return _phanSos.Where(ps => ps.Tu < 0).Sum(ps => ps.Tu);
        }

        public int TinhTongTatCaPhanSoDuong()
        {
            return _phanSos.Where(ps => ps.Tu > 0).Sum(ps => ps.Tu);
        }

        public int TinhTongTatCaPhanSoCoTuLa(int x)
        {
            return _phanSos.Where(ps => ps.Tu == x).Sum(ps => ps.Tu);
        }

        public int TinhTongTatCaPhanSoCoMauLa(int x)
        {
            return _phanSos.Where(ps => ps.Mau == x).Sum(ps => ps.Tu);
        }

        public void XoaPhanSoTaiViTri(int vt)
        {
            if (vt >= 0 && vt < _phanSos.Count)
            {
                _phanSos.RemoveAt(vt);
            }
        }

        public void XoaPhanSoDauTien()
        {
            if (_phanSos.Count > 0)
            {
                _phanSos.RemoveAt(0);
            }
        }

        public void XoaPhanSoCuoiCung()
        {
            if (_phanSos.Count > 0)
            {
                _phanSos.RemoveAt(_phanSos.Count - 1);
            }
        }

        public void XoaPhanSoX(int tuX, int mauX)
        {
            _phanSos.RemoveAll(ps => ps.Tu == tuX && ps.Mau == mauX);
        }

        public void XoaPhanSoCoTuLa(int x)
        {
            _phanSos.RemoveAll(ps => ps.Tu == x);
        }

        public void XoaPhanSoCoMauLa(int x)
        {
            _phanSos.RemoveAll(ps => ps.Mau == x);
        }

        public void XoaPhanSoGiongPhanSoDauTien()
        {
            if (_phanSos.Count > 0)
            {
                PhanSo first = _phanSos[0];
                _phanSos.RemoveAll(ps => ps.Tu == first.Tu && ps.Mau == first.Mau);
            }
        }

        public void XoaPhanSoGiongPhanSoCuoiCung()
        {
            if (_phanSos.Count > 0)
            {
                PhanSo last = _phanSos[_phanSos.Count - 1];
                _phanSos.RemoveAll(ps => ps.Tu == last.Tu && ps.Mau == last.Mau);
            }
        }

        public void XoaTatCaPhanSoNhoNhat()
        {
            PhanSo min = _phanSos.Min();
            if (min != null)
            {
                _phanSos.RemoveAll(ps => ps.Tu == min.Tu && ps.Mau == min.Mau);
            }
        }

        public void XoaTaiCacViTri(List<int> viTri)
        {
            viTri.Sort((a, b) => b.CompareTo(a));
            foreach (var vt in viTri)
            {
                XoaPhanSoTaiViTri(vt);
            }
        }

        public void ThemPhanSoTaiViTri(PhanSo x, int vt)
        {
            if (vt >= 0 && vt <= _phanSos.Count)
            {
                _phanSos.Insert(vt, x);
            }
        }

        public void ThemPhanSoDauTien(PhanSo x)
        {
            ThemPhanSoTaiViTri(x, 0);
        }

        public void XoaTatCaPhanSoAm()
        {
            _phanSos.RemoveAll(ps => ps.Tu < 0);
        }

        public void XoaTatCaPhanSoDuong()
        {
            _phanSos.RemoveAll(ps => ps.Tu > 0);
        }

        public void SapXepTang()
        {
            _phanSos.Sort((ps1, ps2) => ((float)ps1.Tu / ps1.Mau).CompareTo((float)ps2.Tu / ps2.Mau));
        }

        public void SapXepGiam()
        {
            _phanSos.Sort((ps1, ps2) => ((float)ps2.Tu / ps2.Mau).CompareTo((float)ps1.Tu / ps1.Mau));
        }

        public void SapXepTangTheoTu()
        {
            _phanSos.Sort((ps1, ps2) => ps1.Tu.CompareTo(ps2.Tu));
        }

        public void SapXepGiamTheoTu()
        {
            _phanSos.Sort((ps1, ps2) => ps2.Tu.CompareTo(ps1.Tu));
        }

        public void SapXepTangTheoMau()
        {
            _phanSos.Sort((ps1, ps2) => ps1.Mau.CompareTo(ps2.Mau));
        }

        public void SapXepGiamTheoMau()
        {
            _phanSos.Sort((ps1, ps2) => ps2.Mau.CompareTo(ps1.Mau));
        }
    }
}
