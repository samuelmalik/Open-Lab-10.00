using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();

            //LOTR.title_write("Lord of the rings");
            //LOTR.pages_write(1178);
            //LOTR.category_write("heroic romace");
            //LOTR.author_write("John Ronald Reuel Tolkien");
            //LOTR.releaseDate_write(1954);

            //LOTR.write_fields();

            LOTR.Title = "Lord of the rings";
            LOTR.Pages = 1178;
            LOTR.Category = "heroic romance";
            LOTR.Author = "John Ronald Reuel Tolkien";
            LOTR.ReleaseDate = 1954;

            Console.WriteLine("Title: " + LOTR.Title);
            Console.WriteLine("Pages: " + LOTR.Pages);
            Console.WriteLine("Category: " + LOTR.Category);
            Console.WriteLine("Author: " + LOTR.Author);
            Console.WriteLine("Release date: " + LOTR.ReleaseDate);


            Book LOTR2 = new Book();
            Book LOTR3 = new Book("Lord of the rings 3", 1500);
            Book HOBIT = new Book("The Hobbit", 232, "fantasy novel", "John Ronald Reuel Tolkien", 1937);

            LOTR2.write_fields();
            LOTR3.write_fields();
            HOBIT.write_fields();
        }
    }
}
