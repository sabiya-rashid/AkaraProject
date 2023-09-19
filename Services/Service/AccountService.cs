using System;
using AutoWrapper.Wrappers;
using Common.DTOs.UserDto;
using Services.IServices;

namespace Services.Service
{
    public class AccountService : IAccountService
    {
        public ApiResponse GetAllUsers()
        {
            return new ApiResponse { };
        }

        public ApiResponse GetUser(string Email)
        {
            return new ApiResponse { };
        }

        public ApiResponse Login(LoginDto LoginDTO)
        {
            return new ApiResponse { };
        }

        public ApiResponse Register(RegisterDto RegisterDTO)
        {
            return new ApiResponse { };
        }
    }
}

