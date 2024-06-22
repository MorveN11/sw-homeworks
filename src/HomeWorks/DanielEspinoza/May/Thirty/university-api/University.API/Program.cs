using Microsoft.EntityFrameworkCore;
using University.Persistence;
using University.Business;
using University.Logging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLoggingCore();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ErrorHandler>();
});
builder.Services.AddPersistence(builder.Configuration.GetConnectionString("UniversityDB"));
builder.Services.AddBusiness();
builder.Services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(typeof(UniversityProfile).Assembly));



var app = builder.Build();

using (var scope = app.Services.CreateScope()){
    var context = scope.ServiceProvider.GetRequiredService<PostgresContext>();
    context.Database.Migrate();
}



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseStatusCodePages();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

