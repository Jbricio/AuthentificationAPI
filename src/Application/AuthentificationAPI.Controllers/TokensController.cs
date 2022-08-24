using AuthentificationAPI.Contracts;
using AuthentificationAPI.DTOS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Controllers
{
    [Route("tokens")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly IJWTManager _Jwmanager;


        public TokensController(IJWTManager jWTManager)
        {
            _Jwmanager = jWTManager;
        }

        //[AllowAnonymous]
        [HttpPost("Authentication")]

        public async Task<IActionResult> GetAuthentication(UserRequest user, CancellationToken cancellation)
        {
            var token = await _Jwmanager.Authenticate(user, cancellation);
            return Ok(token);
        }
    }
}
