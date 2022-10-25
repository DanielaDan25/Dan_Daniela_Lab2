using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dan_Daniela_Lab2.Models;

namespace Dan_Daniela_Lab2.Data
{
    public class Dan_Daniela_Lab2Context : DbContext
    {
        public Dan_Daniela_Lab2Context (DbContextOptions<Dan_Daniela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dan_Daniela_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dan_Daniela_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Dan_Daniela_Lab2.Models.Author> Author { get; set; }
    }
}
