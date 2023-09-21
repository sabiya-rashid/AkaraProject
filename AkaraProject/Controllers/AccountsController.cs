using AutoWrapper.Wrappers;
using Common.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Services.IServices;

namespace AkaraProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : Controller
    {
        private readonly IAccountService _accountServices;

        public AccountsController(IAccountService accountService)
        {
            _accountServices = accountService;
        }

        [HttpPost("Login")]
        public ApiResponse Login(LoginDto loginDTO)
        {
            return _accountServices.Login(loginDTO);
        }
        [HttpPost("Register")]
        public ApiResponse Register(RegisterDto registerDto)
        {
            return _accountServices.Register(registerDto);
        }
        [HttpPost("GetUsers")]
        public ApiResponse GetUsers(LoginDto loginDTO)
        {
            return _accountServices.GetAllUsers();
        }
    }
}
