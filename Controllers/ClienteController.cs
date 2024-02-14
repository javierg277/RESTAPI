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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace CajeroAPI.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class ClienteController
    {
    
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Get Reports")]
        public dynamic getReports()
        {
            String query = "SELECT * FROM REPORT";
            dynamic report = new ReportDAO().GetReportsddbb(query);

            
            return report;
        }

    }
}
