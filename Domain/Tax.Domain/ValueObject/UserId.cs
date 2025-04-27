using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.ValueObject
{
    public  record UserId
    {
        public UserId(int Value)
        {
            this.Value = Value;
        }

        public int Value { get; }
    }
}
