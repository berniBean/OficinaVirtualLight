using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Security.Claims;
using System.Text;

namespace App_VerFormsAPI.Helpers
{
    public class JwtValidator
    {

        public static ClaimsPrincipal ValidarToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("wP7zA1DpE95U8bVJ9yDpFgtrJlV0wYdih9bKXUtvn/FYqhs8uJgtdvwpPLuQOe6H");

            var parametros = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = false,
                //ValidIssuer = "tu-emisor",
                //ValidAudience = "tu-audiencia",
                ValidateLifetime = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ClockSkew = TimeSpan.Zero
            };

            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, parametros, out securityToken);

            return principal;
        }
    }
}
