using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Pages
        {
            get { return pages; }
            set 
            {
                if (value < 0)
                {
                    pages = 1;
                }
            }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public int ReleaseDate
        {
            get { return releaseDate; }
            set 
            {
                if(value >= 1450 && value <= 2021)
                {
                    releaseDate = value;
                } else
                {
                    releaseDate = -1;
                }
            }
        }

        public void title_write(string title)
        {
            this.title = title;
        }

        public void pages_write(int pages)
        {
            this.pages = pages;
        }

        public void category_write(string category)
        {
            this.category = category;
        }

        public void author_write(string author)
        {
            this.author = author;
        }

        public void releaseDate_write(int releaseDate)
        {
            this.releaseDate = releaseDate;
        }

        public void write_fields()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Release date: " + releaseDate);
        }
    }
}
