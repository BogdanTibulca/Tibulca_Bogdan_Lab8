using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tibulca_Bogdan_Lab8.Models;

namespace Tibulca_Bogdan_Lab8.Data
{
    public class Tibulca_Bogdan_Lab8Context : DbContext
    {
        public Tibulca_Bogdan_Lab8Context (DbContextOptions<Tibulca_Bogdan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Tibulca_Bogdan_Lab8.Models.Book> Book { get; set; }

        public DbSet<Tibulca_Bogdan_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Tibulca_Bogdan_Lab8.Models.Category> Category { get; set; }
    }
}
