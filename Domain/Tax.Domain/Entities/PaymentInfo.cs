using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Tax.Domain.Common.Base;
//using Tax.Domain.Common.Enums;
//using Tax.Domain.Common.ValueObject;

namespace Tax.Domain.Entities
{
    //public class PaymentInfo : Entity<int>
    //{
    //    public string SwitchNumber { get; private set; }
    //    public string MerchantNumber { get; private set; }
    //    public string TerminalNumber { get; private set; }
    //    public PaymentMethod PaymentMethod { get; private set; }
    //    public string TrackingNumber { get; private set; }
    //    public string CardNumber { get; private set; }
    //    public NationalCode PayerNationalCode { get; private set; }
    //    public DateTime PaymentDateTime { get; private set; }
    //    public Money PaymentAmount { get; private set; }

    //    private PaymentInfo() : base() { } // For EF

    //    public PaymentInfo(int id, PaymentMethod paymentMethod, Money paymentAmount, DateTime paymentDateTime)
    //        : base(id)
    //    {
    //        PaymentMethod = paymentMethod;
    //        PaymentAmount = paymentAmount ?? throw new ArgumentNullException(nameof(paymentAmount));
    //        PaymentDateTime = paymentDateTime;
    //    }

    //    public void SetSwitchInfo(string switchNumber)
    //    {
    //        SwitchNumber = switchNumber;
    //    }

    //    public void SetMerchantInfo(string merchantNumber)
    //    {
    //        MerchantNumber = merchantNumber;
    //    }

    //    public void SetTerminalInfo(string terminalNumber)
    //    {
    //        TerminalNumber = terminalNumber;
    //    }

    //    public void SetTrackingNumber(string trackingNumber)
    //    {
    //        TrackingNumber = trackingNumber;
    //    }

    //    public void SetCardNumber(string cardNumber)
    //    {
    //        CardNumber = cardNumber;
    //    }

    //    public void SetPayerNationalCode(NationalCode nationalCode)
    //    {
    //        PayerNationalCode = nationalCode;
    //    }
    //}
}
