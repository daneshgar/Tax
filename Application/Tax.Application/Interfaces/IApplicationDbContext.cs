using Tax.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Tax.Application.Interfaces;


public interface IApplicationDbContext
{
    DbSet<InvoiceHeader> InvoiceHeaders { get;  }
    DbSet<InvoiceBody> InvoiceBodies { get;  }
    DbSet<InvoicePayment> InvoicePayments { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);



}
