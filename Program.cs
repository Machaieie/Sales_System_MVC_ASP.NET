using Aplicacao_de_vendas.DataContext;
using Aplicacao_de_vendas.Models;
using Aplicacao_de_vendas.Properties.Settings;
using Aplicacao_de_vendas.Repositorys;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer("Data source=OLOGA_PROGRAMS\\SQLEXPRESS;initial catalog=Sales_System; integrated security=false; User ID=OLOGA_Programs\\EDWIN-OLOGA;Password=;Trusted_Connection=True;TrustServerCertificate=True;"));




var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Dashboard}/");

app.Run();
