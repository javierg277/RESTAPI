using CajeroAPI.Models;
using Elfie.Serialization;
using Microsoft.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

OracleConnection _dbConnection = new OracleConnection("Data Source = api;User Id = system; Password = denigrancia;");
try
{
    _dbConnection.Open();
    Console.WriteLine("Connection to database established successfully.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error connecting to database: {ex.Message}");
}
finally
{
    _dbConnection.Close();
}

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
