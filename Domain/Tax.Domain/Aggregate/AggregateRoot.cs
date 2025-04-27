using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax.Domain.Entities;

namespace Tax.Domain.Aggregate
{
    public abstract class AggregateRoot<TId> : Entity<TId>
    {
        //private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();
        //public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected AggregateRoot() { }

        protected AggregateRoot(TId id) : base(id) { }

        //public void AddDomainEvent(DomainEvent domainEvent)
        //{
        //    _domainEvents.Add(domainEvent);
        //}

        //public void ClearDomainEvents()
        //{
        //    _domainEvents.Clear();
        //}
    }
}
