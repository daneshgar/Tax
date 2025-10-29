using Tax.Domain.ValueObjects;
namespace Tax.Domain.Entities;


    /// <summary>
    /// بدنه صورتحساب الکترونیکی - اقلام کالا یا خدمت (Body)
    /// طبق جدول شماره 2 سند RC_IITP_IS_V7_6
    /// </summary>
    public sealed class InvoiceBody
    {
        // 59- شناسه کالا/خدمت
        public string Sstid { get; private set; }

        // 60- شرح کالا/خدمت
        public string Sstt { get; private set; }

        // 61- تعداد/مقدار
        public decimal? Am { get; private set; }

        // 62- واحد اندازه‌گیری
        public string Mu { get; private set; }

        // 63- وزن خالص
        public decimal? Nw { get; private set; }

        // 64- مبلغ واحد
        public Money Fee { get; private set; }

        // 65- میزان ارز
        public Money Cfee { get; private set; }

        // 66- نوع ارز
        public string Cut { get; private set; }

        // 67- نرخ برابری ارز با ریال / نرخ فروش ارز
        public decimal? Exr { get; private set; }

        // 68- ارزش ریالی کالا یا خدمت
        public Money Ssrv { get; private set; }

        // 69- ارزش ارزی کالا یا خدمت
        public Money Sscv { get; private set; }

        // 70- مبلغ قبل از تخفیف
        public Money Prdis { get; private set; }

        // 71- مبلغ تخفیف
        public Money Dis { get; private set; }

        // 72- مبلغ پس از تخفیف
        public Money Adis { get; private set; }

        // 73- نرخ مالیات بر ارزش افزوده
        public decimal? Vra { get; private set; }

        // 74- مبلغ مالیات بر ارزش افزوده
        public Money Vam { get; private set; }

        // 75- مبلغ پایه مالیات بر ارزش افزوده
        public Money Vba { get; private set; }

        // 76- موضوع سایر مالیات و عوارض
        public string Odt { get; private set; }

        // 77- نرخ سایر مالیات و عوارض
        public decimal? Odr { get; private set; }

        // 78- مبلغ سایر مالیات و عوارض
        public Money Odam { get; private set; }

        // 79- موضوع سایر وجوه قانونی
        public string Olt { get; private set; }

        // 80- نرخ سایر وجوه قانونی
        public decimal? Olr { get; private set; }

        // 81- مبلغ سایر وجوه قانونی
        public Money Olam { get; private set; }

        // 82- اجرت ساخت
        public Money Consfee { get; private set; }

        // 83- سود فروشنده
        public Money Spro { get; private set; }

        // 84- سهم نقدی از مبلغ پرداختی
        public Money Bros { get; private set; }

        // 85- جمع کل مبلغ قبل از تخفیف
        public Money Tcpbs { get; private set; }

        // 86- سهم مالیات بر ارزش افزوده از پرداخت
        public Money Cop { get; private set; }

        // 87- مالیات موضوع ماده 17
        public Money Vop { get; private set; }

        // 88- شماره صورتحساب بدنه
        public string Bsrn { get; private set; }

        // 89- جمع ریالی کل هر ردیف
        public Money Tsstam { get; private set; }

        // 90- جمع ارزی کالا یا خدمت
        public Money Cui { get; private set; }

        // 91- قیمت هر واحد ارزی
        public Money Cpr { get; private set; }

        // 92- سهم مالیات ارزش افزوده ارزی
        public Money Sovat { get; private set; }

        // قواعد کنترلی بدنه صورتحساب
        public void ValidateBodyTotals()
        {
            if (Prdis != null && Dis != null && Adis != null)
            {
                var calculated = Prdis.Amount - Dis.Amount;
                if (Math.Abs(calculated - Adis.Amount) > 0.01m)
                    throw new InvalidOperationException("مبلغ پس از تخفیف باید برابر تفاضل مبلغ قبل از تخفیف و تخفیف باشد.");
            }

            if (Adis != null && Vam != null && Odam != null && Tsstam != null)
            {
                var sum = Adis.Amount + Vam.Amount + Odam.Amount;
                if (Math.Abs(sum - Tsstam.Amount) > 0.01m)
                    throw new InvalidOperationException("جمع کل هر ردیف ناصحیح است.");
            }
        }
    }

