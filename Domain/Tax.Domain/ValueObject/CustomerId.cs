using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.ValueObject
{
    public record CustomerId
    {
        public CustomerId(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}
