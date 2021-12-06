
using Dolist.Api.Db;
using Dolist.Api.Db.Options;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var appSettingsSection = builder.Configuration.GetSection("AppSettings");

var configurationSection = builder.Configuration.GetSection("ConnectionStrings:DefaultConnection");
builder.Services.Configure<ConnectionOption>((cfg) =>
{
    cfg.ConnectionString = configurationSection.Value;
});
builder.Services.AddDbContext<DoListDbContext>(options => options.UseSqlServer(configurationSection.Value));
builder.Services.AddScoped<IDoListDbContext, DoListDbContext>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
