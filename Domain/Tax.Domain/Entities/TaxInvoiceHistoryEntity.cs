using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax.Domain.ValueObject;

namespace Tax.Domain.Entities
{

    public class TaxInvoiceHistoryEntity : Entity<InvoiceHistoryId>
    {
        public UserId UserId { get; private set; }
        public string PersonName { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }
        public string AccessCodeId { get; private set; }

        private TaxInvoiceHistoryEntity() { }

        public TaxInvoiceHistoryEntity(
            InvoiceHistoryId id,
            UserId userId,
            string personName,
            string description,
            string accessCodeId
        ) : base(id)
        {
            UserId = userId;
            PersonName = personName;
            Date = DateTime.Now;
            Description = description;
            AccessCodeId = accessCodeId;
        }
    }

}
