using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoWrapper.Wrappers;
using Common.DTOs.UserDto;
using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models;
using Services.IServices;

namespace Services.Service
{
	public class AdminService : IAdminService
	{
        private readonly AkaraDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public AdminService(AkaraDbContext dbContext, IConfiguration configuration)
		{
            _dbContext = dbContext;
            _configuration = configuration;
		}

        public ApiResponse GetUnverifiedPropties()
        {
            IQueryable<Property> properties = _dbContext.Properties.Where(p => p.Verrified == false);

            return new ApiResponse { Result = properties };
        }

        public ApiResponse Login(LoginDto LoginDTO)
        {
            var user = _dbContext.Users.FirstOrDefault(e => e.Email == LoginDTO.Email);
            if (user == null)
            {
                var response = new ApiResponse()
                {
                    Message = "No Admin found with this email"
                };
                return response;
            }
            if (!BCrypt.Net.BCrypt.Verify(LoginDTO.Password, user.Password))
            {
                var response = new ApiResponse
                {
                    Message = "Wrong password"
                };
                return response;
            }
            string token = CreateToken(user);
            var result = new ApiResponse
            {
                Message = "Login successful",
                Result = token
            };
            return result;
        }

        public ApiResponse VerifyProperty(int id)
        {
           Property property = _dbContext.Properties.Where(p => p.Verrified == false).FirstOrDefault(i=> i.Id == id);

            if (property == null)
            {
                var response = new ApiResponse()
                {
                    Message = "No Un-verified property with this ID"
                };
                return response;
            }
            property.Verrified = true;
            _dbContext.SaveChanges();
            var verifiedResponse = new ApiResponse()
            {
                Message = "Property has been Validated",
                Result = property
            };
            return verifiedResponse;
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.Id)),
                new Claim(ClaimTypes.Role, user.Role.ToLower())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

    }
}

