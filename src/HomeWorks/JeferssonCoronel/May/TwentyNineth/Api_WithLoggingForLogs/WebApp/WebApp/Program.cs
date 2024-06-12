using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using WebApp.Business;
using WebApp.Business.Validator.Concretes;
using WebApp.Context;
using WebApp.Core.Handler;
using WebApp.Repositories.Concrets;
using WebApp.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();
builder.Services.AddSingleton<LogHandler>();
builder.Services.AddSingleton<ErrorHandler>(); 
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ErrorHandler>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Ingresar repos
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ICareerRepository, CareerRepository>();

// Ingresar mediadores
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UniversityProfile).Assembly));
builder.Services.AddAutoMapper(typeof(UniversityProfile).Assembly);

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<StudentValidator>();
builder.Services.AddTransient<CareerValidator>();

builder.Services.AddDbContext<MyDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllers(); // Ensure API controllers are mapped

app.Run();