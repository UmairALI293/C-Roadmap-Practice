using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Roadmap_Practice
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
