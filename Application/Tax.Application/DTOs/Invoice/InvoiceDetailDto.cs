using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Application.DTOs.Invoice
{

    public record InvoiceDetailDto
    {
        public int Id { get; init; }
        public string? Taxid { get; init; }      // 1. شماره منحصر به فرد مالیاتی
        public long? Indatim { get; init; }      // 2. تاریخ و زمان صدور (Unix Timestamp)
        public long? Indati2m { get; init; }     // 3. تاریخ و زمان ایجاد
        public int? Inty { get; init; }          // 4. نوع صورتحساب
        public int? Inno { get; init; }          // 5. سریال داخلی صورتحساب  
        public string? Irtaxid { get; init; }    // 6. شماره منحصر به فرد مالیاتی صورتحساب مرجع
        public int? Inp { get; init; }           // 7. الگوی صورتحساب
        public int? Ins { get; init; }           // 8. موضوع صورتحساب
        public int? Tins { get; init; }          // 9. شماره اقتصادی فروشنده
        public int? Tob { get; init; }           // 10. نوع شخص خریدار
        public string? Bid { get; init; }        // 11. شناسه ملی/شماره اقتصادی خریدار
        public string? Tinb { get; init; }       // 12. شماره اقتصادی خریدار
        public string? Sbc { get; init; }        // 13. کد شعبه فروشنده
        public string? Bpc { get; init; }        // 14. کد پستی خریدار
        public string? Bbc { get; init; }        // 15. کد شعبه خریدار
        public int? Ft { get; init; }            // 16. نوع پرواز
        public string? Bpn { get; init; }        // 17. شماره گذرنامه خریدار
        public int? Scln { get; init; }          // 18. شماره پروانه گمرکی فروشنده
        public string? Scc { get; init; }        // 19. کد گمرک فروشنده
        public int? Crn { get; init; }           // 20. شماره پروانه گمرکی خریدار
        public string? Billid { get; init; }     // 21. شماره اشتراک/شناسه قبض
        public long? Tprdis { get; init; }       // 22. مجموع مبلغ قبل از تخفیف
        public long? Tdis { get; init; }         // 23. مجموع تخفیفات
        public long? Tadis { get; init; }        // 24. مجموع مبلغ بعد از تخفیف
        public long? Tvam { get; init; }         // 25. مجموع مالیات بر ارزش افزوده
        public long? Todam { get; init; }        // 26. مجموع سایر مالیات و عوارض
        public long? Tbill { get; init; }        // 27. مجموع صورتحساب
        public int? Setm { get; init; }          // 28. روش تسویه
        public long? Cap { get; init; }          // 29. مبلغ پرداختی نقدی
        public long? Insp { get; init; }         // 30. مبلغ نسیه
        public long? Tvop { get; init; }         // 31. مجموع سهم مالیات بر ارزش افزوده از پرداخت
        public int? Tax17 { get; init; }         // 32. مالیات موضوع ماده 17
        public string? Sname { get; init; }      // 33. نام فروشنده
        public long? Uid { get; init; }          // 34. شماره کوتاژ
        public string? Cdcn { get; init; }       // 35. شماره اعتبارنامه گمرکی
        public long? Cdcd { get; init; }         // 36. تاریخ اعتبارنامه گمرکی
        public decimal? Tonw { get; init; }      // 37. مجموع وزن خالص
        public decimal? Torv { get; init; }      // 38. مجموع ارزش ریالی
        public decimal? Tocv { get; init; }      // 39. مجموع ارزش ارزی
        public string? Sccname { get; init; }    // 40. نام گمرک
        public string? Ssn { get; init; }        // 41. شماره ثبت فروشنده
        public string? Bsn { get; init; }        // 42. شماره ثبت خریدار  

    }
}


