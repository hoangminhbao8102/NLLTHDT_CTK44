using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai2
{
    class GhiChu : ILuuTru
    {
        private int _gio;
        private int _id;
        private string _noiDung;
        private int _phut;

        public int Gio
        { 
            get { return _gio; } 
            set { _gio = value; } 
        }
        public int MaSo
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        public string NoiDung
        { 
            get { return _noiDung; }
            set { _noiDung = value; }
        }
        public int Phut
        {
            get { return _phut; }
            set { _phut = value; }
        }

        public void Luu(TextWriter writer)
        {
            // Write the note's content to the file with a specific format
            writer.WriteLine($"ID: {MaSo}, Time: {Gio}:{Phut}, Content: {NoiDung}");
        }

        public override string ToString()
        {
            // Return a string representation of the note
            return $"ID: {MaSo}, Time: {Gio}:{Phut}, Content: {NoiDung}";
        }
    }
}
