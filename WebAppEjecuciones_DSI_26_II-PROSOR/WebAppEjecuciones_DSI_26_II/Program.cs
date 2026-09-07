using BackEndWebAppEjecuciones_DSI_26_II.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAppEjecuciones_DSI_26_II.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddCors(options=>
{
    options.AddPolicy("AngularPolicy", policy =>
    {
        policy.WithOrigins(
            "http://localhost:4200"
            ).AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();
app.Use(async (context, next) =>
{
    context.Response.Headers.Append("Access-Controll-Allow-Origin", "http://localhost:4200");
    context.Response.Headers.Append("Access-Controll-Allow-Headers", "Content-Type,Authorization");
    context.Response.Headers.Append("Access-Controll-Allow-Methods", "GET,POST,PUT,DELETE,OPTIONS");
    if(context.Request.Method == "OPTIONS")
    {
    context.Response.StatusCode = 200;
        return;
}
await next();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStaticFiles();
app.UseRouting();
app.UseCors("AngularPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.MapStaticAssets();
//app.UseHttpsRedirection();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
app.MapControllers();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
