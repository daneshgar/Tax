using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tax.Application.DTOs.Invoice;

namespace Tax.Application.Queries
{
    public record GetAllInvoicesQuery() : IRequest<List<InvoiceListItemDto>>;
    
}
