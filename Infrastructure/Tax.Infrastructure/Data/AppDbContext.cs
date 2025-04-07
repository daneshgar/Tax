using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tax.Domain.Entities;

namespace Tax.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaxItem> TaxItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
