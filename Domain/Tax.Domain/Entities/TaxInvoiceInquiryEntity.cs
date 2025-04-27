using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax.Domain.ValueObject;

namespace Tax.Domain.Entities
{

    public class TaxInvoiceInquiryEntity : Entity<InvoiceInquiryId>
    {
        public string Code { get; private set; }
        public string Message { get; private set; }
        public string TypeError { get; private set; }

        private TaxInvoiceInquiryEntity() { }

        public TaxInvoiceInquiryEntity(
            InvoiceInquiryId id,
            string code,
            string message,
            string typeError
        ) : base(id)
        {
            Code = code;
            Message = message;
            TypeError = typeError;
        }
    }

}
