using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FinancialFlowManager.Application.ViewModel;

namespace FinancialFlowManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Authenticates a user and generates a JWT token.
        /// </summary>
        /// <param name="login">User credentials.</param>
        /// <returns>A JWT token if the credentials are valid.</returns>
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginViewModel login)
        {
            // Step 1: Validate user credentials (mocked in this example)
            if (login.Username != "admin" || login.Password != "password")
                return Unauthorized("Invalid username or password.");

            // Step 2: Generate JWT token
            var token = GenerateJwtToken(login.Username);

            return Ok(new { Token = token });
        }

        /// <summary>
        /// Generates a JWT token for a given username.
        /// </summary>
        /// <param name="username">The username to include in the token.</param>
        /// <returns>A JWT token as a string.</returns>
        private string GenerateJwtToken(string username)
        {
            // Retrieve secret and settings from configuration
            var secretKey = _configuration["JwtSettings:Secret"];
            var issuer = _configuration["JwtSettings:Issuer"];
            var audience = _configuration["JwtSettings:Audience"];

            // Claims to include in the token
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin"), // Example role claim
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // Create signing credentials using the secret key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Create token with claims and settings
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}