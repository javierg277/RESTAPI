using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using CajeroAPI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;


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

            Report report = new Report(1,"reportes","MultaDeTrafico","niIdea","ldkslkds");
            return report;
        }

    }
}
