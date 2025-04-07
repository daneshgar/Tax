using Microsoft.EntityFrameworkCore;
using Tax.Infrastructure;
using Tax.Infrastructure.Data;
using Tax.Infrastructure.Handlers.Query;

var builder = WebApplication.CreateBuilder(args);
// ثبت EF Core از Infrastructure
builder.Services.AddInfrastructure(builder.Configuration);

// ثبت MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetTaxItemsQueryHandler).Assembly));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
