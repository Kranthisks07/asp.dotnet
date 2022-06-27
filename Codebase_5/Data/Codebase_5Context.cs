using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Codebase_5.Models;

namespace Codebase_5.Data
{
    public class Codebase_5Context : DbContext
    {
        public Codebase_5Context (DbContextOptions<Codebase_5Context> options)
            : base(options)
        {
        }

        public DbSet<Codebase_5.Models.Student> Student { get; set; }
    }
}
