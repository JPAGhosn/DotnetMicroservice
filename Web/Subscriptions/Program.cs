using KRK_Shared.Extensions;
using KRK_Subscriptions.Data;
using KRK_Subscriptions.Endpoints;
using KRK_Subscriptions.Extensions;

Console.WriteLine("Hello World!");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddServices();
builder.Services.AddConfigurationSettings(builder.Configuration);
builder.Services.AddWebCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// if (app.Environment.IsProduction()) app.UseHttpsRedirection();

app.UseWebCors();

app.MapSubscriptionsEndpoints();

SubscriptionsDbPreparation.PrepPopulation(app, builder.Environment.IsProduction());

app.Run();