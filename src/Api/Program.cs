using ProjectTemplate.Application;
using ProjectTemplate.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplications();

builder.Services.AddCoreInfraSetup();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
