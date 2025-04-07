using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tax.Application.Dto;

namespace Tax.Application.Queries
{
    public class GetTaxItemsQuery : IRequest<List<TaxItemDto>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetTaxItemsQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber > 0 ? pageNumber : 1;
            PageSize = pageSize > 0 ? pageSize : 10;
        }
    }

}
