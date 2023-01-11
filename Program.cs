using Microsoft.EntityFrameworkCore;
using MVC5_mockup.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MvcDeviceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcDeviceContext") ?? throw new InvalidOperationException("Connection string 'MvcDeviceContext' not found.")));

builder.Services.AddDbContext<DeviceManagerContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DeviceManagerContext")));

// Add services to the container.
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
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
