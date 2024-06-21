using Microsoft.EntityFrameworkCore;
using SchoolApp.DAL.Context;
using SchoolApp.DAL.Daos;
using SchoolApp.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SchoolContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("\"SchoolContext\": \"Server=DESKTOP-SUGRA20\\\\DEVSRV;Database=ShopDb;User ID=admin;Password=1936;MultipleActiveResultSets=true\"\r\n  }")));

builder.Services.AddScoped<IDepartmentDb, DepartmentDb>();

builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
