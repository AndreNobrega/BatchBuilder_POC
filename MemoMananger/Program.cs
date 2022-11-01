using Batches.DependencyInjection;
using Notifications.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add Serilog
var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();
builder.Host.UseSerilog(logger);

// Add services to the container.
builder.Services.AddRazorPages();

// Dependency injection through extension methods
builder.Services.AddBatchDependencies();
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

app.Run();
