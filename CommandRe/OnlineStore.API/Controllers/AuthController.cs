using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Domain.DTOs.Auth;
using OnlineStore.Data;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using OnlineStore.Domain.Users;
using Microsoft.Extensions.Configuration;
using OnlineStore.API.Filters;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Text;

namespace CommandRe.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private OnlineStoreContext _context;
        private ILogger<AuthController> _logger;
        private SignInManager<User> _signInMgr;
        private UserManager<User> _userMgr;
        private IPasswordHasher<User> _hasher;
        private IConfigurationRoot _config;

        public AuthController(OnlineStoreContext context,
          SignInManager<User> signInMgr,
          UserManager<User> userMgr,
          IPasswordHasher<User> hasher,
          ILogger<AuthController> logger,
          IConfigurationRoot config)
        {
            _context = context;
            _signInMgr = signInMgr;
            _logger = logger;
            _userMgr = userMgr;
            _hasher = hasher;
            _config = config;
        }

        [HttpPost("api/auth/login")]
        [ValidateDto]
        public async Task<IActionResult> Login([FromBody] CradentialsDto dto)
        {
            try
            {
                var result = await _signInMgr.PasswordSignInAsync(dto.UserName, dto.Password, false, false);
                if (result.Succeeded)
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown while logging in: {ex}");
            }

            return BadRequest("Failed to login");
        }

        [ValidateDto]
        [HttpPost("api/auth/token")]
        public async Task<IActionResult> CreateToken([FromBody] CradentialsDto dto)
        {
            try
            {
                var user = await _userMgr.FindByNameAsync(dto.UserName);
                if (user != null)
                {
                    if (_hasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password) == PasswordVerificationResult.Success)
                    {
                        var userClaims = await _userMgr.GetClaimsAsync(user);

                        var claims = new[]
                        {
                          new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                          new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                          new Claim(JwtRegisteredClaimNames.GivenName, user.FirstName),
                          new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
                          new Claim(JwtRegisteredClaimNames.Email, user.Email)
                        }.Union(userClaims);

                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                        var token = new JwtSecurityToken(
                          issuer: _config["Tokens:Issuer"],
                          audience: _config["Tokens:Audience"],
                          claims: claims,
                          expires: DateTime.UtcNow.AddMinutes(15),
                          signingCredentials: creds
                          );

                        return Ok(new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception thrown while creating JWT: {ex}");
            }

            return BadRequest("Failed to generate token");
        }

    }
}
