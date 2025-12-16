using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Tax.Infrastructure;
using Tax.Infrastructure.Data;


var builder = WebApplication.CreateBuilder(args);
// ثبت EF Core از Infrastructure
builder.Services.AddInfrastructure(builder.Configuration);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=>
c.AddSecurityDefinition("xs",new OpenApiSecurityScheme
{
    Description="sdsad",
    Type=SecuritySchemeType.ApiKey
}
    
));

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
