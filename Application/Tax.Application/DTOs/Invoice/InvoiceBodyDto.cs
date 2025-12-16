using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Application.DTOs.Invoice
{
    public record InvoiceBodyDto
    {
        public int Id { get; init; }
        public string? Sstid { get; init; }      // شناسه کالا/خدمت
        public string? Sstt { get; init; }       // شرح کالا/خدمت
        public decimal? Am { get; init; }        // مقدار/تعداد
        public decimal? Fee { get; init; }       // مبلغ واحد
        public decimal? Prdis { get; init; }     // مبلغ قبل از تخفیف
        public decimal? Dis { get; init; }       // تخفیف
        public decimal? Adis { get; init; }      // مبلغ بعد از تخفیف
        public decimal? Vam { get; init; }       // مالیات ارزش افزوده
        public decimal? Tsstam { get; init; }    // مبلغ کل
    }
}
