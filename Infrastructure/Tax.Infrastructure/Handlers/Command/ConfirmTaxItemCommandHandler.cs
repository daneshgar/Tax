using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatR;
using Tax.Application.Commands;
using Tax.Infrastructure.Data;


namespace Tax.Infrastructure.Handlers.Command
{
    public class ConfirmTaxItemCommandHandler : IRequestHandler<ConfirmTaxItemCommand>
    {
        private readonly AppDbContext _context;

        public ConfirmTaxItemCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ConfirmTaxItemCommand request, CancellationToken cancellationToken)
        {
            var taxItem = await _context.TaxItems.FindAsync(new object[] { request.Id }, cancellationToken);
            if (taxItem == null) throw new Exception("TaxItem not found");

            taxItem.Confirm();
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}