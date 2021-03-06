using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication7.Data
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            :base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=Bookstore;Integrated Security=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
