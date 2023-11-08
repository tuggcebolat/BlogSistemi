using BlogSistemi.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using BlogSistemi.Data.Extensions;
using BlogSistemi.Service.Extensions;
using BlogSistemi.Entities.Entities;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceExtension();
builder.Services.AddSession();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireLowercase = false;

})
    .AddRoleManager<RoleManager<AppRole>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = new PathString("/Admin/Auth/Login");
    config.LogoutPath = new PathString("/Admin/Auth/Logout");
    config.Cookie = new CookieBuilder
    {
        Name = "BlogSistemi",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest //Always
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(7);
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");
});






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
app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=index}/{id?}"
    );
    endpoints.MapDefaultControllerRoute();
});
app.Run();
