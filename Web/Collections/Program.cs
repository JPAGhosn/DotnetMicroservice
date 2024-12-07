using Collections.Data;
using Collections.Endpoints;
using Collections.Extensions;
using KRK_Shared.Extensions;
using Shared.Extensions;
using Shared.Middlewares;

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
builder.Services.SetupElasticSearch(builder.Configuration);

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
app.UseWebCors();
app.UseGlobalExceptionMiddleware();
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseRouting();
app.SetupAuthentication(builder.Configuration);

app.MapCollectionsEndpoints();


CollectionsDataPreparation.GenerateData(app, app.Environment.IsProduction()).Wait();

app.Run();