using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CombatGame.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();
builder.Services.AddSession();


builder.Services.AddDbContext<CharacterDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("BattleContext")));
builder.Services.AddSession(options =>
{
    // change idle timeout to 5 minutes - default is 20 minutes
    options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
    options.Cookie.HttpOnly = false;     // default is true
    options.Cookie.IsEssential = true;   // default is false
});


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();
app.UseSession();




app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();