using KRK_Profiles.Data;
using KRK_Profiles.Endpoints;
using KRK_Profiles.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddServices();
builder.Services.AddKrkGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapProfilesEndpoints();
app.MapKrkGrpc();

ProfilesDbPreparation.PrepPopulation(app, builder.Environment.IsProduction());

app.Run();