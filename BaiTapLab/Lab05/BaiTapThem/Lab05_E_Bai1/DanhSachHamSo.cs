using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_E_Bai1
{
    public class DanhSachHamSo
    {
        private List<HamSo> danhSach;

        public DanhSachHamSo()
        {
            danhSach = new List<HamSo>();
        }

        public void ThemHamSo(HamSo hamSo)
        {
            danhSach.Add(hamSo);
        }

        public void NhapCacHamSo()
        {
            // Example functions added manually for demonstration
            ThemHamSo(new HamTuyenTinh("Linear Function", 2, 3));
            ThemHamSo(new HamBacHai("Quadratic Function", 1, -5, 6));
            ThemHamSo(new HamDaThuc("Cubic Function", new double[] { 1, 0, -7, 6 })); // Example of a cubic polynomial
        }

        public void XuatCacHamSo()
        {
            foreach (HamSo hamSo in danhSach)
            {
                hamSo.Xuat();
            }
        }

        public void DemHamSo()
        {
            int countLinear = 0;
            int countQuadratic = 0;
            int countPolynomial = 0;

            foreach (HamSo hamSo in danhSach)
            {
                if (hamSo is HamTuyenTinh)
                    countLinear++;
                else if (hamSo is HamBacHai)
                    countQuadratic++;
                else if (hamSo is HamDaThuc)
                    countPolynomial++;
            }

            Console.WriteLine($"Linear Functions: {countLinear}");
            Console.WriteLine($"Quadratic Functions: {countQuadratic}");
            Console.WriteLine($"Polynomial Functions: {countPolynomial}");
        }

        public void XuatHamSoVaGiaTriTaiX(double x)
        {
            foreach (HamSo hamSo in danhSach)
            {
                Console.WriteLine($"{hamSo.Ten} at x={x}: {hamSo.TinhGiaTri(x)}");
            }
        }

        public void XuatHamSoGiamDanTaiX(double x)
        {
            // Simple bubble sort for demonstration purposes
            for (int i = 0; i < danhSach.Count - 1; i++)
            {
                for (int j = 0; j < danhSach.Count - i - 1; j++)
                {
                    if (danhSach[j].TinhGiaTri(x) < danhSach[j + 1].TinhGiaTri(x))
                    {
                        // Swap elements
                        HamSo temp = danhSach[j];
                        danhSach[j] = danhSach[j + 1];
                        danhSach[j + 1] = temp;
                    }
                }
            }

            XuatCacHamSo();  // Output sorted list
        }

        // Function to find and output the degree of polynomial functions
        public void TimBacCuaHamDaThuc()
        {
            foreach (var hamSo in danhSach)
            {
                if (hamSo is HamDaThuc hamDaThuc)
                {
                    Console.WriteLine($"{hamDaThuc.Ten} has degree {hamDaThuc.Bac}");
                }
            }
        }

        // Function to find and output polynomial functions of the highest degree
        public void XuatHamDaThucBacCaoNhat()
        {
            int maxDegree = -1;
            foreach (var hamSo in danhSach)
            {
                if (hamSo is HamDaThuc hamDaThuc)
                {
                    if (hamDaThuc.Bac > maxDegree)
                    {
                        maxDegree = hamDaThuc.Bac;
                    }
                }
            }

            foreach (var hamSo in danhSach)
            {
                if (hamSo is HamDaThuc hamDaThuc && hamDaThuc.Bac == maxDegree)
                {
                    hamDaThuc.Xuat();
                }
            }
        }
    }
}
