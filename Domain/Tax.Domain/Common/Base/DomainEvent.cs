using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.Common.Base
{
    public abstract class DomainEvent : IDomainEvent
    {
        public  DateTime OnccurredOn { get; private set; }
        public  Guid EventId { get; private set; }
        protected DomainEvent()
        {
            OnccurredOn = DateTime.Now;
            EventId = Guid.NewGuid();
        }
    }
}
