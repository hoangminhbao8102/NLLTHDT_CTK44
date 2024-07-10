using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class CPU : IThietBi
    {
        float gia; //field
        string hangSX;

        public float Gia 
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }
        public string HangSX 
        {
            get
            {
                return hangSX;
            }

            set
            {
                hangSX = value;
            }
        }

        public CPU() { }

        public CPU(string hang, float gia)
        {
            HangSX = hang;
            Gia = gia;
        }

        public CPU(string line)
        {
            string[] s = line.Split(',');
            HangSX = s[1];
            Gia = float.Parse(s[2]);
        }

        public override string ToString() 
        {
            return "CPU hang " + HangSX + " gia = " + Gia;
        }
    }
}
