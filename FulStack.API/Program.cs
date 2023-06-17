using Fullstack.Infrastructure;
using FullStack.Application;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//Register COnfiguration
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add database Service
builder.Services.AddDbContext<FullStackDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("FullStackConnectionString")
    , b=>b.MigrationsAssembly("FulStack.API")));
builder.Services.AddScoped<FStackService, StackService>();
builder.Services.AddScoped<FStackRepository, StackRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
