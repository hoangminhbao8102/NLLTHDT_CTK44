using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // First complex expression
            IBieuThuc firstExprNumerator = new BieuThuc(
                new BieuThuc(
                    new HamSin(new BieuThuc(new SoHang(65), new LuyThua(new SoHang(Math.E), new SoHang(Math.PI)), '+')),
                    new HamCosin(new SoHang(110)),
                    '*'),
                new LuyThua(new SoHang(2.75), new SoHang(1.5)),
                '*');

            IBieuThuc complexAddition = new BieuThuc(
                new PhanSo(new SoHang(13), new SoHang(4)),
                new HamLn(new BieuThuc(new SoHang(10), new HamCosin(new SoHang(70)), '*')),
                '+');

            IBieuThuc firstExprDenominator = new BieuThuc(
                new BieuThuc(
                    new SoHang(9.11),
                    new BieuThuc(
                        complexAddition,
                        new LuyThua(new SoHang(Math.PI), new PhanSo(new SoHang(3), new SoHang(Math.E))),
                        '*'),
                    '*'),
                new SoHang(1), // This might be unnecessary unless you need a placeholder
                '/');

            IBieuThuc firstFullExpression = new BieuThuc(
                new SoHang(0.09),
                new PhanSo(firstExprNumerator, firstExprDenominator),
                '*');

            // Second complex expression
            IBieuThuc secondExprPart1 = new BieuThuc(
                new SoHang(2),
                new HamTan(
                    new BieuThuc(
                        new SoHang(Math.PI),
                        new HamSin(
                            new BieuThuc(new SoHang(Math.PI), new SoHang(5), '/')),
                        '/')),
                '*');

            IBieuThuc secondExprPart2 = new BieuThuc(
                new SoHang(3),
                new LuyThua(new SoHang(7), new SoHang(12)),
                '^');

            IBieuThuc secondExprPart3 = new BieuThuc(
                new HamFactorial(new SoHang(12)),
                new HamSqrt(
                    new BieuThuc(
                        new LuyThua(new SoHang(Math.E), new SoHang(Math.PI)),
                        new BieuThuc(
                            new BieuThuc(
                                new SoHang(3),
                                new BieuThuc(
                                    new SoHang(9),
                                    new SoHang(2.5),
                                    '*'),
                                '*'),
                            new BieuThuc(
                                new SoHang(6),
                                new SoHang(Math.PI),
                                '*'),
                            '/'),
                        '*')),
                '+');

            IBieuThuc secondFullExpression = new BieuThuc(
                secondExprPart1,
                new BieuThuc(
                    secondExprPart2,
                    secondExprPart3,
                    '/'),
                '+');

            // Calculate and print results
            Console.WriteLine("First expression result: " + firstFullExpression.TinhGiaTri());
            Console.WriteLine("Second expression result: " + secondFullExpression.TinhGiaTri());

            Console.ReadKey();
        }
    }
}
