using Tax.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.Aggregates;

/// <summary>
/// ریشه مجموعه صورتحساب الکترونیکی مالیاتی (Aggregate Root)
/// </summary>
public class TaxInvoice
{
    public InvoiceHeader Header { get; private set; }
    public List<InvoiceBody> Bodys { get; private set; }
    public List<InvoicePayment> Payments { get; private set; }

    public TaxInvoice(InvoiceHeader header, List<InvoiceBody> bodys, List<InvoicePayment> payments)
    {
        Header = header ?? throw new ArgumentNullException(nameof(header));
        Bodys = bodys ?? new List<InvoiceBody>();
        Payments = payments ?? new List<InvoicePayment>();

    }

    private void ValidateConsistency()
    {
        // اعتبارسنجی بدنه‌ها در برابر مجموع کل صورتحساب
        decimal calculatedTotal = 0m;
        foreach (var body in Bodys)
        {
            body.ValidateBodyTotals();
            if (body.Tsstam != null)
                calculatedTotal += body.Tsstam.Amount;
        }

        if (Header.Tbill != null && Math.Abs(Header.Tbill.Amount - calculatedTotal) > 0.01m)
            throw new InvalidOperationException("جمع اقلام با مجموع صورتحساب در سرآمد مطابقت ندارد.");

        // اعتبارسنجی پرداخت‌ها
        decimal paymentTotal = 0m;
        foreach (var payment in Payments)
            if (payment.Pv != null) paymentTotal += payment.Pv.Amount;

        if (Header.Tbill != null && Math.Abs(Header.Tbill.Amount - paymentTotal) > 0.01m)
            throw new InvalidOperationException("جمع مبلغ پرداختی با مجموع صورتحساب مطابقت ندارد.");

    }


}
