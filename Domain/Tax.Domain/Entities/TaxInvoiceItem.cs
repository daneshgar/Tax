using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax.Domain.Common.Base;
using Tax.Domain.Common.ValueObject;

namespace Tax.Domain.Entities
{
    public class TaxInvoiceItem : Entity<int>
    {
        public string ServiceId { get; private set; }
        public string Description { get; private set; }
        public decimal Quantity { get; private set; }
        public string Unit { get; private set; }
        public Money UnitPrice { get; private set; }
        public Money TotalAmount { get; private set; }
        public Money DiscountAmount { get; private set; }
        public Money AmountAfterDiscount { get; private set; }
        public decimal VatRate { get; private set; }
        public Money VatAmount { get; private set; }
        public Money OtherTaxAmount { get; private set; }
        public Money OtherLegalAmount { get; private set; }
        public string Currency { get; private set; }
        public decimal ExchangeRate { get; private set; }
        public Money CurrencyAmount { get; private set; }
        public Money RialValue { get; private set; }
        public Money CurrencyValue { get; private set; }

        private TaxInvoiceItem() : base() { } // For EF

        public TaxInvoiceItem(int id, string serviceId, string description, decimal quantity,
            string unit, Money unitPrice) : base(id)
        {
            if (string.IsNullOrWhiteSpace(serviceId))
                throw new ArgumentException("Service ID cannot be empty", nameof(serviceId));

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive", nameof(quantity));

            ServiceId = serviceId;
            Description = description;
            Quantity = quantity;
            Unit = unit;
            UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));

            CalculateTotalAmount();
        }

        public void ApplyDiscount(Money discountAmount)
        {
            DiscountAmount = discountAmount ?? Money.Zero;
            AmountAfterDiscount = TotalAmount.Subtract(DiscountAmount);
        }

        public void SetVat(decimal vatRate)
        {
            if (vatRate < 0 || vatRate > 1)
                throw new ArgumentException("VAT rate must be between 0 and 1", nameof(vatRate));

            VatRate = vatRate;
            var baseAmount = AmountAfterDiscount ?? TotalAmount;
            VatAmount = new Money(baseAmount.Amount * (decimal)vatRate, baseAmount.Currency);
        }

        public void SetOtherTax(Money amount)
        {
            OtherTaxAmount = amount ?? Money.Zero;
        }

        public void SetOtherLegalAmount(Money amount)
        {
            OtherLegalAmount = amount ?? Money.Zero;
        }

        public void SetCurrency(string currency, decimal exchangeRate, Money currencyAmount)
        {
            Currency = currency;
            ExchangeRate = exchangeRate;
            CurrencyAmount = currencyAmount;
        }

        public void SetRialValue(Money rialValue)
        {
            RialValue = rialValue;
        }

        public void SetCurrencyValue(Money currencyValue)
        {
            CurrencyValue = currencyValue;
        }

        private void CalculateTotalAmount()
        {
            var amount = UnitPrice.Amount * (decimal)Quantity;
            TotalAmount = new Money(amount, UnitPrice.Currency);
        }
    }
}
