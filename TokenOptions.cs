using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.IdentityModel.Tokens;

public class TokenOptions
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecretKey { get; set; }
    public int ExpirationMinutes { get; set; }




    private readonly TokenOptions _tokenOptions;

    public TokenOptions(TokenOptions tokenOptions)
    {
        _tokenOptions = tokenOptions;
    }

    public TokenOptions()
    {
    }

    public string GenerateToken()
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(SecretKey);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[] 
            {
                new Claim(ClaimTypes.Name, "username")
                // Add other claims as needed
            }),
            Expires = DateTime.UtcNow.AddMinutes(ExpirationMinutes),
            Issuer = Issuer,
            Audience = Audience,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }




    public static void Main()
    {
        // Configura las opciones del token
        var tokenOptions = new TokenOptions()
        {
            Issuer = "Sepalo",
            Audience = "Sep",
            SecretKey = "SepaloSecretKey",
            ExpirationMinutes = 60
        };

        // Crea una instancia del generador de token
        var tokenGenerator = new TokenOptions(tokenOptions);

        // Genera el token
        var token = tokenGenerator.GenerateToken();

        Console.WriteLine("Token generado: " + token);
    }
}