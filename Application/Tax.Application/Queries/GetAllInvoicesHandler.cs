using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tax.Application.DTOs.Invoice;
using Tax.Application.Interfaces;

namespace Tax.Application.Queries
{
    public class GetAllInvoicesHandler:IRequestHandler<GetAllInvoicesQuery,List<InvoiceListItemDto>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public GetAllInvoicesHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<InvoiceListItemDto>> Handle(GetAllInvoicesQuery request, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.InvoiceHeaders.AsNoTracking()
                        .Select(x => new InvoiceListItemDto
                        {
                            Id = x.Id,
                            Taxid = x.Taxid,
                            Indatim = x.Indatim,
                            Tins = x.Tins,
                            Bid = x.Bid,
                            Inty = x.Inty
                        })
            .ToListAsync(cancellationToken);

        }
    }
}
