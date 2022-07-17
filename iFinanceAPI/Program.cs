using Microsoft.EntityFrameworkCore;

using UserServices.Implementations;
using UserServices.Contracts;
using UserServices.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddScoped<IUserMethods, UserMethods>();
builder.Services.AddDbContext<UserContext>(opt => opt.UseSqlServer
    (builder.Configuration.GetConnectionString("iFinanceConnection")));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
