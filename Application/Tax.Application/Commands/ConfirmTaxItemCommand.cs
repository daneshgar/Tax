using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tax.Application.Commands
{
    public class ConfirmTaxItemCommand : IRequest
    {
        public int Id { get; set; }

        public ConfirmTaxItemCommand(int id)
        {
            Id = id;
        }
    }
}
