using Authentication.DependencyInjection;
using Batches.DependencyInjection;
using MemoManager.DependencyInjection;
using Notifications.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add Serilog
var logConfig = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", true)
        .Build();

var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(logConfig)
    .WriteTo.Console()
    .CreateLogger();
builder.Host.UseSerilog(logger);

// Add services to the container.
builder.Services.AddRazorPages();

// Dependency injection through extension methods
builder.Services.AddAuthenticationDependencies();
builder.Services.AddBatchDependencies();
builder.Services.AddMemoDependencies();
builder.Services.AddNotificationDependencies();

var app = builder.Build();

logger.Information("Application starting...");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();