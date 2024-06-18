using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            SoTay myNotebook = new SoTay();

            // Create and add 10 GhiChu objects
            for (int i = 1; i <= 10; i++)
            {
                GhiChu note = new GhiChu
                {
                    MaSo = i,
                    Gio = 9 + (i % 3), // Assign a random hour from 9 to 11
                    Phut = (i * 5) % 60, // Random minutes
                    NoiDung = $"Task {i} content" // Unique content for each note
                };
                myNotebook.Them(note);
            }

            // Save all notes to a file
            using (TextWriter writer = File.CreateText("sotay.txt"))
            {
                myNotebook.Luu(writer);
            }

            Console.WriteLine("\nAll notes saved to 'sotay.txt'.");

            // Print all notes
            Console.WriteLine("Printing all notes:");
            myNotebook.In();

            // Print notes from ID 2 to 7
            Console.WriteLine("\nPrinting notes from ID 2 to 7:");
            myNotebook.In(2, 7);

            // Generate 4 text files
            string[] filePaths = new string[4];
            for (int i = 0; i < 4; i++)
            {
                string fileName = $"file{i + 1}.txt";
                using (StreamWriter file = new StreamWriter(fileName))
                {
                    int lines = new Random().Next(10, 26); // Between 10 and 25 lines
                    for (int j = 0; j < lines; j++)
                    {
                        file.WriteLine(new string('x', new Random().Next(50, 81))); // Lines of random length between 50 and 80 characters
                    }
                }
                filePaths[i] = fileName;
            }

            // Create VanBan instances and print contents
            VanBan[] documents = new VanBan[4];
            for (int i = 0; i < 4; i++)
            {
                documents[i] = new VanBan(filePaths[i]);
                Console.WriteLine($"\nContent of {filePaths[i]}:");
                documents[i].In();
            }

            // Save content of all VanBan to a single file
            using (TextWriter writer = File.CreateText("all_documents.txt"))
            {
                foreach (var doc in documents)
                {
                    doc.Luu(writer);
                }
            }

            // Save content of SoTay and all VanBan to a single file
            using (TextWriter writer = File.CreateText("combined.txt"))
            {
                myNotebook.Luu(writer);
                foreach (var doc in documents)
                {
                    doc.Luu(writer);
                }
            }

            // Print tasks between 10 to 11 o'clock
            Console.WriteLine("\nTasks between 10 and 11 o'clock:");
            myNotebook.In(10, 11);

            // Print tasks from current time onwards
            int currentHour = DateTime.Now.Hour;
            Console.WriteLine($"\nTasks from current time ({currentHour}h) onwards:");
            myNotebook.In(currentHour, 24);

            Console.ReadKey();
        }
    }
}
