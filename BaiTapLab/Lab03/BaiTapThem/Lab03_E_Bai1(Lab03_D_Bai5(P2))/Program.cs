using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai1_Lab03_D_Bai5_P2__
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Creating authors
            TacGia an = new TacGia("An Nguyen", "an@example.com", true);
            TacGia binh = new TacGia("Binh Tran", "binh@example.com", false);
            TacGia cau = new TacGia("Cau Le", "cau@example.com", true);

            // Creating books with multiple authors
            Sach web = new Sach("Web Development", new List<TacGia> { an, binh }, 29.99m, 50);
            Sach mobile = new Sach("Mobile Apps", new List<TacGia> { an }, 39.99m, 35);
            Sach game = new Sach("Game Design", new List<TacGia> { binh, cau }, 49.99m, 20);
            Sach dos = new Sach("DOS Programming", new List<TacGia> { cau }, 19.99m, 10);
            Sach card = new Sach("Card Games", new List<TacGia> { cau, an }, 14.99m, 100);

            // List of books and authors for easier management
            List<TacGia> authors = new List<TacGia> { an, binh, cau };
            List<Sach> books = new List<Sach> { web, mobile, game, dos, card };

            // Output authors
            Console.WriteLine("DANH SACH TAC GIA");
            Console.WriteLine("MSSV      Ho va Ten          Email             Gioi Tinh");
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.HoTen,-10} {author.Email,-18} {(author.Phai ? "Nam" : "Nu"),-10}");
            }

            // Output books
            Console.WriteLine("\nDANH SACH SACH");
            Console.WriteLine("Tua De               Tac Gia         Gia    So Luong Ton");
            foreach (var book in books)
            {
                string authorNames = string.Join(", ", book.TacGias.Select(tg => tg.HoTen));
                Console.WriteLine($"{book.TuaDe,-20} {authorNames,-15} {book.Gia,-5} {book.SoLuongTon,-13}");
            }

            // Author and their books
            foreach (var author in authors)
            {
                var authorBooks = books.Where(b => b.TacGias.Contains(author)).ToList();
                Console.WriteLine($"\nTac gia: {author.HoTen} - So luong sach: {authorBooks.Count}");
                Console.WriteLine("Danh sach sach:");
                foreach (var book in authorBooks)
                {
                    Console.WriteLine($"- {book.TuaDe}");
                }
            }

            Console.ReadKey();
        }
    }
}
