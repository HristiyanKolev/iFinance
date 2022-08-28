using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json.Serialization;

using iFinanceAPI.DBContext;

using UsersServices.DBContext;
using UsersServices.Contracts;
using UsersServices.Implementations;

using FinanceControlServices.DBContext;
using FinanceControlServices.Contracts;
using FinanceControlServices.Implementations;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEntityService, EntityService>();
builder.Services.AddControllers().AddNewtonsoftJson(s =>
{
    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});

// DBContext Registration
builder.Services.AddDbContext<ApiContext>(opt => opt.UseSqlServer
    (builder.Configuration.GetConnectionString("iFinanceConnection")));
builder.Services.AddDbContext<UserServiceContext>(opt => opt.UseSqlServer
    (builder.Configuration.GetConnectionString("iFinanceConnection")));
builder.Services.AddDbContext<FinanceControlServiceContext>(opt => opt.UseSqlServer
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
