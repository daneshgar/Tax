using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.ValueObject
{
    public record InvoiceInquiryId
    {
        public InvoiceInquiryId(int Value)
        {
            this.Value = Value;
        }

        public int Value { get; }
    }
}
