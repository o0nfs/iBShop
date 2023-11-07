using IBshopDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Identity;
using IBshopDemo.ActionFilters;
using IBshopDemo.Initializer;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddIdentity<User, Role>()
//    .AddEntityFrameworkStores<TestHadadianContext>();
// Add services to the container.
builder.Services.AddSession(options => { options.Cookie.IsEssential = true; });
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IBshopDemo.Models.TestHadadianContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("ibshop")); });




var app = builder.Build();

//Initializers
using (var scope = app.Services.CreateScope())
{
    TestHadadianContext init = scope.ServiceProvider.GetRequiredService<TestHadadianContext>();
    IBshopInitializer.Initialize(init);
}
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
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
