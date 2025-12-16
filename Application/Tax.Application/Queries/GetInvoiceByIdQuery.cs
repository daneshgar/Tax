
using MediatR;
using Tax.Application.DTOs.Invoice;

namespace Tax.Application.Queries;

public record GetInvoiceByIdQuery (int? Id):IRequest<InvoiceDetailDto?>;
