using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoderLibary.Models
{
    public class BookDatabaseInitializer: DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>{
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "ProGram"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "WebSite"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Network Security"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Graphics"
                }
            };
            return categories;
        }

        private static List<Book> GetBooks()
        {
            var books = new List<Book>
            {    
                //book 1
                 new Book
                 {
                     BookID = 1,
                     BookName = "ProGram C++",
                     Description = "Basic ProGram",
                     ImagePath ="sach1.jpg",
                     UnitPrice = 4f,
                     CategoryID = 1
                 }
                };
            return books;
        }
    }
}