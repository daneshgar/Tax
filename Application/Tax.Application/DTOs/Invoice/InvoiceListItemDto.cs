using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Application.DTOs.Invoice
{

    public record InvoiceListItemDto
    {
        public int Id { get; init; }

        // شناسه یکتای مالیاتی
        public string? Taxid { get; init; }

        // تاریخ صدور
        public long? Indatim { get; init; }

        // نام فروشنده
        public string? Tins { get; init; }

        // نام خریدار
        public string? Sname { get; init; }

        // شماره ملی/شناسه خریدار
        public string? Bid { get; init; }

        // مبلغ کل صورتحساب
        public decimal? Tbill { get; init; }

        // نوع صورتحساب
        public int? Inty { get; init; }

        // وضعیت ارسال
        public bool IsSent { get; init; }

        // وضعیت تایید
        public bool IsConfirmed { get; init; }

        // تاریخ ایجاد
        public DateTime CreatedAt { get; init; }
    }
}

