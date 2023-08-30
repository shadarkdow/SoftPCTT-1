
using Microsoft.EntityFrameworkCore;
using webapi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DemoContext>(p=>p.UseSqlServer(builder.Configuration.GetConnectionString("Demo")));
builder.Services.AddScoped<SiteProvider>();

builder.Services.AddCors(p=>p.AddPolicy("MyCors", builder =>{
    builder.WithOrigins("http://localhost:3000", "http://192.168.1.18:3000").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();



app.MapDefaultControllerRoute();
app.MapControllers();
app.UseRouting();
app.UseCors("MyCors");


// Configure the HTTP request pipeline.

app.UseAuthorization();
app.MapControllers();

app.Run();