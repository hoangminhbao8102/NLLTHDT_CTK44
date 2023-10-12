using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai01_BatCacNgoaiLe
{
    public class ViDuNgoaiLe
    {
        public int BatLoiKieuDuLieu()
        {
			try
			{
                Console.Write("Nhap mot so nguyen : ");
                int giaTri = int.Parse(Console.ReadLine());
                return giaTri;
            }
			catch (Exception)
			{
				return 0;
			}
        }

        public int BatLoiVaXuatLoi()
        {
            try
            {
                Console.Write("Nhap mot so nguyen : ");
                int giaTri = int.Parse(Console.ReadLine());
                return giaTri;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int ChiRoLoiMuonBat()
        {
            try
            {
                Console.Write("Nhap mot so nguyen : ");
                int giaTri = int.Parse(Console.ReadLine());
                return giaTri;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int BatNhieuLoaiNgoaiLeKhacNhau()
        {
            try
            {
                Console.Write("Nhap mot so nguyen : ");
                int giaTri = int.Parse(Console.ReadLine());
                return giaTri;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return 1; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int SuDungKhoiFinally()
        {
            try
            {
                Console.Write("Nhap mot so nguyen : ");
                int giaTri = int.Parse(Console.ReadLine());
                return giaTri;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                Console.WriteLine("Lenh nay thuc hien truoc khi return");
            }
        }
    }
}
