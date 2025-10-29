using Tax.Domain.ValueObjects;
namespace Tax.Domain.Entities
{
    public sealed class InvoiceHeader
    {
        // 1- شماره منحصر به فرد مالیاتی
        public string Taxid { get; private set; }

        // 2- تاریخ و زمان صدور صورتحساب (میلادی)
        public long? Indatim { get; private set; }

        // 3- تاریخ و زمان ایجاد صورتحساب (میلادی)
        public long? Indati2m { get; private set; }

        // 4- نوع صورتحساب
        public int? Inty { get; private set; }

        // 5- سریال صورتحساب داخلی حافظه مالیاتی
        public string Inno { get; private set; }

        // 6- شماره منحصر به فرد مالیاتی صورتحساب مرجع
        public string Irtaxid { get; private set; }

        // 7- الگوی صورتحساب
        public int? Inp { get; private set; }

        // 8- موضوع صورتحساب
        public int? Ins { get; private set; }

        // 9- شماره اقتصادی فروشنده
        public string Tins { get; private set; }

        // 10- نوع شخص خریدار
        public int? Tob { get; private set; }

        // 11- شماره/شناسه ملی/شناسه مشارکت مدنی/کد فراگیر اتباع غیرایرانی خریدار
        public string Bid { get; private set; }

        // 12- شماره اقتصادی خریدار
        public string Tinb { get; private set; }

        // 13- کد شعبه فروشنده
        public string Sbc { get; private set; }

        // 14- کد پستی خریدار
        public string Bpc { get; private set; }

        // 15- کد شعبه خریدار
        public string Bbc { get; private set; }

        // 16- نوع پرواز
        public int? Ft { get; private set; }

        // 17- شماره گذرنامه خریدار
        public string Bpn { get; private set; }

        // 18- شماره پروانه گمرکی
        public string Scln { get; private set; }

        // 19- کد گمرک محل اظهار فروشنده
        public string Scc { get; private set; }

        // 20- شماره کوتاژ اظهارنامه گمرکی
        public string Cdcn { get; private set; }

        // 21- تاریخ کوتاژ اظهارنامه گمرکی
        public int? Cdcd { get; private set; }

        // 22- شماره اشتراک/شناسه قبض بهره بردار
        public string Crn { get; private set; }

        // 23- شناسه یکتای ثبت قرارداد فروشنده
        public string Billid { get; private set; }

        // 24- مجموع مبلغ قبل از کسر تخفیف
        public Money Tprdis { get; private set; }

        // 25- مجموع تخفیفات
        public Money Tdis { get; private set; }

        // 26- مجموع مبلغ پس از کسر تخفیف
        public Money Tadis { get; private set; }

        // 27- مجموع مالیات بر ارزش افزوده
        public Money Tvam { get; private set; }

        // 28- مجموع سایر مالیات و عوارض
        public Money Todam { get; private set; }

        // 29- مجموع صورتحساب
        public Money Tbill { get; private set; }

        // 30- مجموع وزن خالص
        public decimal? Tonw { get; private set; }

        // 31- مجموع ارزش ریالی
        public Money Torv { get; private set; }

        // 32- مجموع ارزش ارزی
        public Money Tocv { get; private set; }

        // 33- روش تسویه
        public int? Setm { get; private set; }

        // 34- مبلغ پرداختی نقدی
        public Money Cap { get; private set; }

        // 35- مبلغ نسیه
        public Money Insp { get; private set; }

        // 36- مجموع سهم مالیات بر ارزش افزوده از پرداخت
        public Money Tvop { get; private set; }

        // 37- مالیات موضوع ماده 17
        public Money Tax17 { get; private set; }

        // فیلدهای تکمیلی سرآمد

        // 38- شماره/شناسه ملی خریدار
        public string Tinc { get; private set; }

        // 39- شماره پروانه
        public string Lno { get; private set; }

        // 40- شماره مجوز
        public string Lrno { get; private set; }

        // 41- نوع ارز
        public string Ocu { get; private set; }

        // 42- نرخ برابری ارز
        public decimal? Exr { get; private set; }

        // 43- نام فروشنده
        public string Sn { get; private set; }

        // 44- نام خریدار
        public string Bn { get; private set; }

        // 45- شناسه یکتای ثبت قرارداد فروشنده
        public string Did { get; private set; }

        // 46- آدرس فروشنده
        public string Sa { get; private set; }

        // 47- آدرس خریدار
        public string Ba { get; private set; }

        // 48- تلفن فروشنده
        public string Stel { get; private set; }

        // 49- تلفن خریدار
        public string Btel { get; private set; }

        // 50- ایمیل فروشنده
        public string Semail { get; private set; }

        // 51- ایمیل خریدار
        public string Bemail { get; private set; }

        // 52- کد شهر فروشنده
        public string Sccode { get; private set; }

        // 53- کد شهر خریدار
        public string Bccode { get; private set; }

        // 54- کد کشور فروشنده
        public string Scocode { get; private set; }

        // 55- کد کشور خریدار
        public string Bcocode { get; private set; }

        // 56- شماره فاکتور مرجع
        public string Refno { get; private set; }

        // 57- تاریخ فاکتور مرجع
        public long? Refdt { get; private set; }

        // 58- توضیحات
        public string Desc { get; private set; }

        // Constructor
        public InvoiceHeader(
            string taxid,
            long? indatim,
            int? inty,
            int? inp,
            string tins,
            Money tprdis,
            Money tdis,
            Money tadis,
            Money tvam,
            Money todam,
            Money tbill)
        {
            Taxid = taxid ?? throw new ArgumentNullException(nameof(taxid));
            Indatim = indatim;
            Inty = inty;
            Inp = inp;
            Tins = tins ?? throw new ArgumentNullException(nameof(tins));
            Tprdis = tprdis;
            Tdis = tdis;
            Tadis = tadis;
            Tvam = tvam;
            Todam = todam;
            Tbill = tbill ?? throw new ArgumentNullException(nameof(tbill));

            ValidateHeaderTotals();
        }
                private void ValidateHeaderTotals()
        {
            // قاعده: مجموع پس از تخفیف = مجموع قبل از تخفیف - تخفیفات
            if (Tprdis != null && Tdis != null && Tadis != null)
            {
                var calculated = Tprdis.Amount - Tdis.Amount;
                if (Math.Abs(calculated - Tadis.Amount) > 0.01m)
                    throw new InvalidOperationException("مبلغ پس از تخفیف باید برابر تفاضل مبلغ قبل از تخفیف و تخفیفات باشد");
            }
            
            // قاعده: مجموع صورتحساب = مجموع پس از تخفیف + مالیات + سایر وجوه
            if (Tadis != null && Tvam != null && Todam != null && Tbill != null)
            {
                var calculated = Tadis.Amount + Tvam.Amount + Todam.Amount;
                if (Math.Abs(calculated - Tbill.Amount) > 0.01m)
                    throw new InvalidOperationException("مجموع صورتحساب نادرست است");
            }
            
            // قاعده: نقدی + نسیه = مجموع صورتحساب
            if (Cap != null && Insp != null && Tbill != null)
            {
                var paymentSum = Cap.Amount + Insp.Amount;
                if (Math.Abs(paymentSum - Tbill.Amount) > 0.01m)
                    throw new InvalidOperationException("مجموع پرداخت نقدی و نسیه باید برابر مبلغ صورتحساب باشد");
            }
        }

     

    }
}
