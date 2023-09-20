using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoWrapper.Wrappers;
using Common.DTOs.UserDto;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models;
using Services.IServices;

namespace Services.Service
{
    public class AccountService : IAccountService
    {
        private readonly AkaraDbContext _context;
        private readonly IConfiguration _configuration;
        public AccountService(AkaraDbContext context, IConfiguration configuration)
        {
            _context = context; 
            _configuration = configuration;
        }
        public ApiResponse GetAllUsers()
        {
          var users = _context.Users.ToList();
            if(users == null)
            {
                var response = new ApiResponse()
                {
                   Message = "No Users found"
                };
                return response; 
            }
          return new ApiResponse(users);
        }

        public User GetUser(string Email)
        {
           var user = _context.Users.FirstOrDefault(e=> e.Email == Email);            
           return user;
        }

        public ApiResponse Login(LoginDto loginDTO)
        {
            var user = GetUser(loginDTO.Email);  
            if(user == null)
            {
                var response = new ApiResponse()
                {
                    Message = "No user found with this email"
                };
                return response;
            }
            if (!BCrypt.Net.BCrypt.Verify(loginDTO.Password, user.Password))
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
        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        public ApiResponse Register(RegisterDto registerDto)
        {
            string passwordhash = BCrypt.Net.BCrypt.HashPassword(registerDto.Password);
            var user = new User();
            user.Email = registerDto.Email;
            user.Password = passwordhash;
            user.Name = registerDto.Name;
            user.Phone = registerDto.Phone;
            _context.Add(user);
            _context.SaveChanges();

            return new ApiResponse
            {
                StatusCode = 200,
                Message = "User registered successfully",
                Result = user
            };
        }
    }
}

