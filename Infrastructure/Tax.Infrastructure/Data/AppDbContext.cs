using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tax.Application.Interfaces;
using Tax.Domain.Entities;
using Tax.Domain.ValueObjects;

namespace Tax.Infrastructure.Data
{
    public class AppDbContext : DbContext,IApplicationDbContext
    {
       
        public DbSet<InvoiceHeader> InvoiceHeaders => Set <InvoiceHeader>();
        public DbSet<InvoiceBody> InvoiceBodies => Set<InvoiceBody>();
        public DbSet<InvoicePayment> InvoicePayments => Set <InvoicePayment>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Money>();
           var  headerConfig = modelBuilder.Entity<InvoiceHeader>(entity=>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("InvoiceHeader");
            }
            );


            modelBuilder.Entity<InvoiceBody>(entity=>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("InvoiceBody");
            });
            modelBuilder.Entity<InvoicePayment>(entity=>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("InvoicePayment");
            });
        }


    }
}
