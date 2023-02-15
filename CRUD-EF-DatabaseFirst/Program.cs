global using CRUD_EF_DatabaseFirst.Models;
global using Microsoft.AspNetCore.Mvc;
global using System.Diagnostics;
using CRUD_EF_DatabaseFirst.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<dbfirstcrudContext>(x => x.UseSqlServer("Data Source=(local); Initial catalog=dbfirstcrud; trusted_connection=yes"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
