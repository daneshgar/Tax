
using System;
using Tax.Domain.ValueObjects;

namespace Tax.Domain.Entities
{
    /// <summary>
    /// اطلاعات پرداختی صورتحساب - Payment Section
    /// </summary>
    public sealed class InvoicePayment
    {
        // 93- شماره شاپرک / شماره پذیرنده
        public string Iinn { get; private set; }

        // 94- شماره حساب / شماره کارت
        public string Acn { get; private set; }

        // 95- شماره ترمینال
        public string Trmn { get; private set; }

        // 96- نوع پرداخت (نقدی / اعتباری / الکترونیکی)
        public int? Pmt { get; private set; }

        // 97- شماره تراکنش پرداختی
        public string Trn { get; private set; }

        // 98- کد پذیرنده در شبکه پرداخت
        public string Pcn { get; private set; }

        // 99- شناسه پرداخت
        public string Pid { get; private set; }

        // تاریخ پرداخت
        public DateTime? Pdt { get; private set; }

        // مبلغ پرداختی
        public Money Pv { get; private set; }

        public void ValidatePaymentValue(Money expectedTotal)
        {
            if (Pv == null || expectedTotal == null) return;
            if (Math.Abs(Pv.Amount - expectedTotal.Amount) > 0.01m)
                throw new InvalidOperationException("مبلغ پرداختی با مجموع صورتحساب تطابق ندارد.");
        }
    }
}

