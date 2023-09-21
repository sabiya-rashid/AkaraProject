using System;
using System.Data;
using AutoWrapper.Wrappers;
using Common.DTOs.UserDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using Services.Service;

namespace AkaraProject.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : ControllerBase
	{
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
		{
            _adminService = adminService;
        }

        [HttpGet("GetUnverifiedProperties")]
        public ApiResponse GetUnverifiedPropties()
        {
            return _adminService.GetUnverifiedPropties();
        }

        [HttpPost("Login")]
        public ApiResponse Login(LoginDto LoginDTO)
        {
            return _adminService.Login(LoginDTO);
        }

        [HttpPost("VerifyProperty")]
        public ApiResponse VerifyProperty(int id)
        {
            return _adminService.VerifyProperty(id);
        }
    }
}


