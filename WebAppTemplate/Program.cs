using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebAppTemplate.Data.Interceptors;
using WebAppTemplate.Helpers.Email;
using System.Security.Principal;
using WebAppTemplate.Data;
using WebAppTemplate.Helpers.File;
using WebAppTemplate.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DataDbContext
// Repository
// Helpers

var con = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataDbContext>(x=>x.UseSqlServer(con).AddInterceptors(new SoftDeleteInterceptor()).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));



builder.Services.AddScoped(typeof(iRepository<>),typeof(Repository<>));

builder.Services.AddSingleton<iFileHelper, FileHelper>();
builder.Services.AddSingleton<iEmailService, EmailService>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<DataDbContext>()
.AddDefaultTokenProviders();


builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/Admin/Account/LogIn";
    x.LogoutPath = "/Home/Index";
    x.SlidingExpiration = true;
    x.ExpireTimeSpan = TimeSpan.FromMinutes(60);
});


builder.Services.Configure<IdentityOptions>(x =>
{
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequireDigit = false;
    x.Password.RequireUppercase = false;
    x.Password.RequireLowercase = false;
    x.Password.RequireDigit = false;
    x.Password.RequiredLength = 3;
    x.Password.RequiredUniqueChars = 0;
}); ;



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// Authentcation
app.UseAuthentication();

// Authorization
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();



