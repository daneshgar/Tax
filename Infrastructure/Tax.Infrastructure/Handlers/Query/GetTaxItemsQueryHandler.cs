using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tax.Application.Dto;
using Tax.Application.Queries;
using Tax.Infrastructure.Data;

namespace Tax.Infrastructure.Handlers.Query
{
    public class GetTaxItemsQueryHandler : IRequestHandler<GetTaxItemsQuery, List<TaxItemDto>>
    {
        private readonly AppDbContext _context;

        public GetTaxItemsQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaxItemDto>> Handle(GetTaxItemsQuery request, CancellationToken cancellationToken)
        {
            return await _context.TaxItems
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(t => new TaxItemDto
                {
                    Id = t.Id,
                    Inno = t.Inno,
                    IsConfirm = t.IsConfirm
                })
                .ToListAsync(cancellationToken);
        }
    }
}
