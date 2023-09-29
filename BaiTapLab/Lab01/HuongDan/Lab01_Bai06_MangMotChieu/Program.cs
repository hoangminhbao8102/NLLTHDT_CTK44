using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai06_MangMotChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mmc;

            mmc = new int[1000];

            int dem = 0;

            Console.WriteLine("Hay nhap so phan tu của mang : ");
            dem = int.Parse(Console.ReadLine());

            for (int i = 0; i < dem; i++)
            {
                Console.Write("a[{0}] = ", i);
                mmc[i] = int.Parse(Console.ReadLine()); ;
            }

            Console.WriteLine("Cac phan tu cua mang : ");
            for (int i = 0; i < dem; i++)
            {
                Console.Write("{0}\t", mmc[i]);
            }

            int min = mmc[0];
            for (int i = 1; i < dem; i++)
            {
                if (min > mmc[i])
                {
                    min = mmc[i];
                }
            }
            Console.WriteLine("Phan tu nho nhat trong mang la : {0}", min);

            Console.Write("Nhap vao phan tu X can tim : ");
            int x = int.Parse(Console.ReadLine());

            int ViTri = -1;
            for (int i = 0; i < dem; i++)
            {
                if (mmc[i] == x)
                {
                    ViTri = i;
                    break;
                }
            }

            if (ViTri == -1)
                Console.WriteLine("Khong tim thay phan tu {0}", x);
            else
                Console.WriteLine("Vi tri cua {0} la {1}", x, ViTri);

            for (int i = 0; i < dem - 1; i++)
            {
                for (int j = i + 1; j < dem; j++)
                {
                    if (mmc[i] > mmc[j])
                    {
                        int tam = mmc[i];
                        mmc[i] = mmc[j];
                        mmc[j] = tam;
                    }
                }
            }
            Console.WriteLine("Cac phan tu cua mang : ");
            for (int i = 0; i < dem; i++)
            {
                Console.Write("{0}\t", mmc[i]);
            }

            Console.ReadKey();
        }
    }
}
