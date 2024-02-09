using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phase3AssistedPractice_4.Models;

namespace Phase3AssistedPractice_4.Data
{
    public class MarksDbContext : DbContext
    {
        public MarksDbContext (DbContextOptions<MarksDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phase3AssistedPractice_4.Models.Marks> Marks { get; set; } = default!;
    }
}
