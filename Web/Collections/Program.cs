using Collections.Endpoints;
using Collections.Extensions;
using Glimpses.Data;
using KRK_Shared.Extensions;
using Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddServices(builder.Configuration);
builder.Services.AddSharedBindings(builder.Configuration);
builder.Services.AddWebCors();
builder.Services.SetupAuthentication(builder.Configuration);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.SetupAuthentication(builder.Configuration);
app.UseWebCors();
app.MapCollectionsEndpoints();

CollectionsDataPreparation.GenerateData(app, app.Environment.IsProduction());

app.Run();