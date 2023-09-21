using System;
using AutoWrapper.Wrappers;
using Common.DTOs.UserDto;
using Models;

namespace Services.IServices
{
	public interface IAdminService
	{
        ApiResponse Login(LoginDto LoginDTO);
        ApiResponse VerifyProperty(int id);
        ApiResponse GetUnverifiedPropties();
    }
}

