using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Streja_Raluca_Lab2.Models;

namespace Streja_Raluca_Lab2.Data
{
    public class Streja_Raluca_Lab2Context : DbContext
    {
        public Streja_Raluca_Lab2Context (DbContextOptions<Streja_Raluca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Streja_Raluca_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Streja_Raluca_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
