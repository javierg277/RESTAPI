using CajeroAPI.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Sepalo.WebApi.Admin.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Oracle.ManagedDataAccess.Client;


[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
     private readonly BaseRepository _baseRepository;
    private readonly IConfiguration _configuration;

    public UserController(BaseRepository baseRepository, IConfiguration configuration)
    {
        _baseRepository = baseRepository;
        _configuration = configuration;
    }

  [HttpPost("login")]
public async Task<IActionResult> Login(LoginModel model)
{
    using var command = _baseRepository._dbConnection.CreateCommand();
    command.CommandText = "SELECT * FROM Users WHERE Name = :name AND Password = :password";
    command.Parameters.Add(new OracleParameter("name", model.Name));
    command.Parameters.Add(new OracleParameter("password", model.Password));

    await ((OracleConnection)_baseRepository._dbConnection).OpenAsync();
    using var reader =  command.ExecuteReader();
    if ( reader.Read())
    {
        // Usuario encontrado
        var tokenOptions = _configuration.GetSection("TokenOptions").Get<TokenOptions>();
        var key = Encoding.ASCII.GetBytes(tokenOptions.SecretKey);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, model.Name)
            }),
            Expires = DateTime.UtcNow.AddDays(tokenOptions.ExpirationMinutes),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return Ok(new { token = tokenHandler.WriteToken(token) });
    }
    else
    {
        // Usuario no encontrado
        return Unauthorized();
    }
}


}