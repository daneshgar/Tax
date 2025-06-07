using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.Common.ValueObject
{
    public class TaxId : IEquatable<TaxId>
    {
        public string Value { get; private set; }

        private TaxId() { } // For EF

        public TaxId(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tax ID cannot be empty", nameof(value));

            Value = value.Trim();
        }

        public bool Equals(TaxId other) => other?.Value == Value;
        public override bool Equals(object obj) => obj is TaxId taxId && Equals(taxId);
        public override int GetHashCode() => Value?.GetHashCode() ?? 0;
        public override string ToString() => Value;

        public static implicit operator string(TaxId taxId) => taxId?.Value;
        public static implicit operator TaxId(string value) => new TaxId(value);
    }
}
