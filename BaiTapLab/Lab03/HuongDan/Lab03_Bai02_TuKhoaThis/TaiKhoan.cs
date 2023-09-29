using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai02_TuKhoaThis
{
    class TaiKhoan
    {
        private int maTK;
        private int soDu;

        public int MaSoTK
        { 
            get { return maTK; } 
        }

        public int SoDu
        {
            get { return soDu; }
        }

        public TaiKhoan(int maTK, int soDu)
        {
            this.maTK = maTK;
            this.soDu = soDu;
        }

        public TaiKhoan(int maTK):this(maTK,0) { }

        public void GuiTien(int SoTien)
        {
            this.soDu += SoTien;
        }

        public bool RutTien(int SoTien)
        {
            if (soDu >= SoTien) 
            { 
                this.soDu -= SoTien;
                return true; 
            }
            else
            {
                Console.WriteLine("Tai khoan khong co du tien");
                return false;
            }
        }

        public bool ChuyenKhoan(int SoTien, TaiKhoan ToiTK)
        {
            var ThanhCong = this.RutTien(SoTien);
            if (ThanhCong)
            {
                ToiTK.GuiTien(SoTien);
            }

            return ThanhCong;
        }

        public override string ToString()
        {
            return string.Format("Tai khoan {0} co so du {1}", 
                                 maTK, soDu);
        }
    }
}
