using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using CajeroAPI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Oracle.ManagedDataAccess.Client;
using System;
using CajeroAPI.Controllers;
using System.Data.Common;


namespace CajeroAPI.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class ClienteController
    {
    
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Get Reports")]
        public dynamic getReports(DbConnection _dbConnection)
        {
            
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
            

            Report report = new Report(1,"reportes","MultaDeTrafico","niIdea","ldkslkds");
            Report_Criteria reportCriteria = new Report_Criteria(1, "pago", "operador", "Description", "sql", "ssss", 1, 2);
            Console.WriteLine("Conexión exitosa a Oracle.");
            return report;
        }

    }
}
