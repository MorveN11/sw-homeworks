using Microsoft.EntityFrameworkCore;
using University.Persistence;
using University.Business;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddLogging();
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

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

