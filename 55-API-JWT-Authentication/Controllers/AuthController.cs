using _55_API_JWT_Authentication.Contexts;
using _55_API_JWT_Authentication.Models;
using _55_API_JWT_Authentication.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _55_API_JWT_Authentication.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public AuthController(AppDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        //User kayıt (register)
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserForRegisterDTO userDTO)
        {
            var result = _dbContext.Users.SingleOrDefault(x=>x.Email== userDTO.Email);
            if (result == null)
            {
                AppUser user = new AppUser();
                user.Id=Guid.NewGuid().ToString();
                user.FirstName=userDTO.FirstName;
                user.LastName=userDTO.LastName;
                user.NormalizedEmail=userDTO.Email.ToUpper();
                user.Email = userDTO.Email;
                user.EmailConfirmed = true;
                user.PasswordHash = userDTO.Password;
                user.SecurityStamp = Guid.NewGuid().ToString();
                user.ConcurrencyStamp= Guid.NewGuid().ToString();
                user.PhoneNumber = userDTO.PhoneNumber;
                user.PhoneNumberConfirmed = true;

                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] AppUserLogin userLogin)
        {
            var login = _dbContext.Users.SingleOrDefault(x => x.Email == userLogin.Email && x.PasswordHash == userLogin.Password);
            if (login != null)
            {
                //return Ok();
                var authClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Email, userLogin.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                var token = GetToken(authClaims);
                return Ok(
                    new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    });
            }
            else
            {
                return Unauthorized();
            }
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTSettings:securityKey"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _configuration["JWTSettings:validIssuer"],
                _configuration["JWTSettings:validAudience"],
                authClaims,
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: signIn
                );
            return token;
        }
    }
}
