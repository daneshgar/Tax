using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax.Domain.Common.Base;
using Tax.Domain.Common.Enums;
using Tax.Domain.Common.ValueObject;
using Tax.Domain.Entities;
using Tax.Domain.Events;


namespace Tax.Domain.Aggregates
{
    public class TaxInvoice : AggregateRoot<int>
    {
        private readonly List<TaxInvoiceItem> _items = new List<TaxInvoiceItem>();
        private readonly List<PaymentInfo> _payments = new List<PaymentInfo>();
        public long SerialNumber { get; private set; }
        public InvoiceType InvoiceType { get; private set; }
        public int InvoicePattern { get; private set; }
        public int InvoiceSubject { get; private set; }
        public DateTime IssueDateTime { get; private set; }
        public DateTime CreatedDateTime { get; private set; }
        public TaxId TaxId { get; private set; }
        public TaxId MasterTaxId { get; private set; }
        public Customer Customer { get; private set; }
        public int CustomerId { get; private set; }
        public string SellerBranchCode { get; private set; }
        public string CustomsLicenseNumber { get; private set; }
        public string CustomsCode { get; private set; }
        public string ContractRegistrationId { get; private set; }
        public SettlementMethod SettlementMethod { get; private set; }
        public Money CashPayment { get; private set; }
        public Money CreditAmount { get; private set; }
        public string BrokerageContractId { get; private set; }
        public DateTime TradeDate { get; private set; }

        // Status Properties
        public bool IsSent { get; private set; }
        public bool IsConfirmed { get; private set; }
        public bool HasError { get; private set; }
        public bool IsEdited { get; private set; }
        public DateTime? SendDateTime { get; private set; }
        public DateTime? ConfirmDateTime { get; private set; }
        public int? ConfirmUserId { get; private set; }
        public string ReferenceNumber { get; private set; }
        public string ErrorMessage { get; private set; }

        public IReadOnlyList<TaxInvoiceItem> Items => _items.AsReadOnly();
        public IReadOnlyList<PaymentInfo> Payments => _payments.AsReadOnly();

        private TaxInvoice() : base() { } // For EF

        public TaxInvoice(int id, long serialNumber, InvoiceType invoiceType, int invoicePattern,
            int invoiceSubject, Customer customer, DateTime issueDateTime) : base(id)
        {
            if (serialNumber <= 0)
                throw new ArgumentException("Serial number must be positive", nameof(serialNumber));

            SerialNumber = serialNumber;
            InvoiceType = invoiceType;
            InvoicePattern = invoicePattern;
            InvoiceSubject = invoiceSubject;
            Customer = customer ?? throw new ArgumentNullException(nameof(customer));
            CustomerId = customer.Id;
            IssueDateTime = issueDateTime;
            CreatedDateTime = DateTime.UtcNow;
            TradeDate = issueDateTime.Date;

            CashPayment = Money.Zero;
            CreditAmount = Money.Zero;

            // Add domain event
            AddDomainEvent(new TaxInvoiceCreatedEvent(Id, SerialNumber, CustomerId));
        }

        public void SetTaxId(TaxId taxId)
        {
            TaxId = taxId ?? throw new ArgumentNullException(nameof(taxId));
        }

        public void SetMasterTaxId(TaxId masterTaxId)
        {
            MasterTaxId = masterTaxId;
        }

        public void SetSellerInfo(string branchCode)
        {
            SellerBranchCode = branchCode;
        }

        public void SetCustomsInfo(string licenseNumber, string customsCode)
        {
            CustomsLicenseNumber = licenseNumber;
            CustomsCode = customsCode;
        }

        public void SetContractInfo(string contractRegistrationId)
        {
            ContractRegistrationId = contractRegistrationId;
        }

        public void SetSettlement(SettlementMethod method, Money cashPayment, Money creditAmount)
        {
            SettlementMethod = method;
            CashPayment = cashPayment ?? Money.Zero;
            CreditAmount = creditAmount ?? Money.Zero;
        }

        public void SetBrokerageContract(string contractId)
        {
            BrokerageContractId = contractId;
        }

        public void SetTradeDate(DateTime tradeDate)
        {
            TradeDate = tradeDate;
        }

        public void AddItem(TaxInvoiceItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _items.Add(item);
        }

        public void RemoveItem(TaxInvoiceItem item)
        {
            _items.Remove(item);
        }

        public void AddPayment(PaymentInfo payment)
        {
            if (payment == null)
                throw new ArgumentNullException(nameof(payment));

            _payments.Add(payment);
        }

        public void RemovePayment(PaymentInfo payment)
        {
            _payments.Remove(payment);
        }

        public Money CalculateTotalAmount()
        {
            if (!_items.Any()) return Money.Zero;

            var total = _items.First().TotalAmount;
            foreach (var item in _items.Skip(1))
            {
                total = total.Add(item.TotalAmount);
            }
            return total;
        }

        public Money CalculateTotalVat()
        {
            if (!_items.Any()) return Money.Zero;

            var total = _items.First().VatAmount ?? Money.Zero;
            foreach (var item in _items.Skip(1))
            {
                if (item.VatAmount != null)
                {
                    total = total.Add(item.VatAmount);
                }
            }
            return total;
        }

        public void Send()
        {
            if (IsSent)
                throw new InvalidOperationException("Invoice is already sent");

            IsSent = true;
            SendDateTime = DateTime.UtcNow;
            HasError = false;
            ErrorMessage = null;

            // Add domain event
            AddDomainEvent(new TaxInvoiceSentEvent(Id, TaxId?.Value, ReferenceNumber));
        }

        public void MarkAsSendFailed(string errorMessage)
        {
            IsSent = false;
            HasError = true;
            ErrorMessage = errorMessage;
        }

        public void Confirm(int userId)
        {
            if (!IsSent)
                throw new InvalidOperationException("Cannot confirm unsent invoice");

            if (IsConfirmed)
                throw new InvalidOperationException("Invoice is already confirmed");

            IsConfirmed = true;
            ConfirmDateTime = DateTime.UtcNow;
            ConfirmUserId = userId;

            // Add domain event
            AddDomainEvent(new TaxInvoiceConfirmedEvent(Id, userId));
        }

        public void SetReferenceNumber(string referenceNumber)
        {
            ReferenceNumber = referenceNumber;
        }

        public void MarkAsEdited()
        {
            IsEdited = true;
        }
    }
}
