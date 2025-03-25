using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Models;
using SchoolProject.Repositories;
using SchoolProject.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDBContext>();
builder.Services.AddScoped<IDbInitializer, DbInitializer>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
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
DataSeeding();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

void DataSeeding()
{
    using (var scope = app.Services.CreateScope())
    {
        var DbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
    }
}
