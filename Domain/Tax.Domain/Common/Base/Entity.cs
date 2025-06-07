using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.Common.Base
{

    public abstract class Entity<TId> : IEquatable<Entity<TId>>
    {
        public TId Id { get; protected set; }

        protected Entity() { }

        protected Entity(TId id)
        {
            if (Equals(id, default(TId)))
                throw new ArgumentException("The ID cannot be the default value.", nameof(id));

            Id = id;
        }

        public bool Equals(Entity<TId> other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (GetType() != other.GetType()) return false;

            return !Equals(Id, default(TId)) && !Equals(other.Id, default(TId)) && Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals((Entity<TId>)obj);
        }

        public override int GetHashCode()
        {
            return !Equals(Id, default(TId)) ? Id.GetHashCode() : 0;
        }

        public static bool operator ==(Entity<TId> left, Entity<TId> right)
        {
            return left?.Equals(right) ?? right is null;
        }

        public static bool operator !=(Entity<TId> left, Entity<TId> right)
        {
            return !(left == right);
        }
    }
}
