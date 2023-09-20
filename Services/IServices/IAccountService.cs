using System;
using AutoWrapper.Wrappers;
using Common.DTOs.UserDto;
using Models;

namespace Services.IServices
{
	public interface IAccountService
	{
        ApiResponse GetAllUsers();
        User GetUser(string Email);
        ApiResponse Login(LoginDto LoginDTO);
        ApiResponse Register(RegisterDto RegisterDTO);
    }
}

