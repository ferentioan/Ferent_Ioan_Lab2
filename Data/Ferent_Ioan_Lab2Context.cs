using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ferent_Ioan_Lab2.Models;

namespace Ferent_Ioan_Lab2.Data
{
    public class Ferent_Ioan_Lab2Context : DbContext
    {
        public Ferent_Ioan_Lab2Context (DbContextOptions<Ferent_Ioan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ferent_Ioan_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ferent_Ioan_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
