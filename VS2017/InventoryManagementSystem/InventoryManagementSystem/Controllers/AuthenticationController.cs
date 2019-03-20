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

        public IActionResult RequestToken(TokenRequest request)
        {
            if (request.UserName == "Dinesh.Venkatachalam" && request.Password == "test123")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, request.UserName)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["securityKey"]));
                var signedCredential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            }

            return BadRequest("Could not verify username and password");
        }
    }
}