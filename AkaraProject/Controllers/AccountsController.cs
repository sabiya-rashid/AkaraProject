using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace AkaraProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : Controller
    {
        [HttpPost("Login")]
        public ApiResponse Login(string username, string password)
        {
            var response = new ApiResponse();
            return (ApiResponse)response;
        }
        [HttpPost("Register")]
        public ApiResponse Register(string username, string password)
        {
            var response = new ApiResponse();
            return (ApiResponse)response;
        }
    }
}
