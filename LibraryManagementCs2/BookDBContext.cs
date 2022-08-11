using LibraryManagementCs2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryManagementCs2
{
    public class BookDBContext : DbContext
    {
        public BookDBContext() : base("BookDBContext") {
        }
        public DbSet<Book> Books { get; set; }

    }
}