using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MainProject.Models;

namespace MainProject.Data
{
    public class MainProjectContext : DbContext
    {
        public MainProjectContext (DbContextOptions<MainProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MainProject.Models.Product>? Product { get; set; }
    }
}
