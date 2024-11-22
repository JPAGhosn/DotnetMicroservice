using Glimpses.Data;
using Glimpses.Endpoints;
using Glimpses.Extensions;
using KRK_Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

builder.Services.AddServices();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddWebCors();
builder.Services.AddBindings(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseWebCors();

app.UseHttpsRedirection();

app.MapGlimpsesEndpoints();

GlimpsesDataPreparation.GenerateData(app, app.Environment.IsProduction());

app.Run();