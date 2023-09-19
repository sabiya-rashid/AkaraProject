using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace AkaraProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractsController : Controller
    {
        [HttpGet]
        public ApiResponse GetAll()
        {
            return new ApiResponse();
        }
    }
}
