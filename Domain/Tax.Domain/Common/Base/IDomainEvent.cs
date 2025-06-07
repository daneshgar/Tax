using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Domain.Common.Base
{
    public  interface IDomainEvent
    {
        DateTime OnccurredOn { get;}
        Guid EventId{ get;  }

    }
}
