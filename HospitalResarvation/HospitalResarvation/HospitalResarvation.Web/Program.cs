using HospitalResarvation.Web.IRepository;
using HospitalResarvation.Web.Models;
using HospitalResarvation.Web.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();




////DENEMEK ÝÇÝN
//builder.Services.AddDbContext<HospitalDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
//});



//timeout aldýðým için sürekli 
builder.WebHost.ConfigureKestrel(t =>
{
    t.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(15);
});

builder.Services.AddTransient<IAppointmentRepository, AppointmentRepository>();

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


app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints => {
    endpoints.MapAreaControllerRoute(
    name: "Management",
    areaName: "Management",
    pattern: "Management/{controller=Dashboard}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
    name: "areas",
    pattern: "{area=exists}/{controller}/{action}"
    );

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

});


app.Run();
