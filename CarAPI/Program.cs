global using CarAPI.Data;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.EntityFrameworkCore;
using CarAPI.Middleware;
using CarAPI.Models;
using CarAPI.Repositories;
using CarAPI.Repositories.IRepositories;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICarRepositories, CarRepositories>();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataConnectionString"));
});

builder.Services.AddIdentity<UserModel, IdentityRole >(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 5;
    options.Password.RequireNonAlphanumeric = false ;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
}).AddEntityFrameworkStores<DataContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ErrorHandling>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseMiddleware<ErrorHandling>();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();