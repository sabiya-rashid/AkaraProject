using System;
using AutoWrapper.Wrappers;
using Common.DTOs.UserDto;

namespace Services.IServices
{
	public interface IAccountService
	{
        ApiResponse GetAllUsers();
        ApiResponse GetUser(string Email);
        ApiResponse Login(LoginDto LoginDTO);
        ApiResponse Register(RegisterDto RegisterDTO);
    }
}

