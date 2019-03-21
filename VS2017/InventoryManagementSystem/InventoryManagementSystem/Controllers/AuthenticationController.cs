using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IMS.Domain.Models.Security;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;

namespace InventoryManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        private readonly IConfiguration _configuration;

        public AuthenticationController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        [HttpGet]
        [Route("request-token")]
        public IActionResult RequestToken([FromBody]TokenRequest request)
        {
            if (request.UserName == "Dinesh.Venkatachalam" && request.Password == "test123")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, request.UserName)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["securityKey"]));
                var signedCredential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "localhost:3488",
                    audience: "localhost:3488",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: signedCredential
                    );

                try
                {
                    var serializedToken = new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token)
                    };

                    return Ok(serializedToken);
                }
                catch(Exception ex)
                {
                    return BadRequest(ex);
                }                
            }

            return BadRequest("Could not verify username and password");
        }
    }
}