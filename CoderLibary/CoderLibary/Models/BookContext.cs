using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoderLibary.Models
{
    public class BookContext: DbContext
    {
        public BookContext() : base("CoderLibary") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}