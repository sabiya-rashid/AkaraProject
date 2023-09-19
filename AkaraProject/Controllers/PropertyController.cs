using AutoWrapper.Wrappers;
using Common.DTOs.Contract;
using Common.DTOs.Property;
using Microsoft.AspNetCore.Mvc;

namespace AkaraProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : Controller
    {
        [HttpGet("GetAll")]
        public ApiResponse GetAll()
        {
            return new ApiResponse();
        }
        [HttpGet("Get")]
        public ApiResponse GetProperty(int id)
        {
            return new ApiResponse();
        }
        [HttpGet("GetRent")]
        public ApiResponse GetRentProperty()
        {
            return new ApiResponse();
        }
        [HttpGet("GetBuy")]
        public ApiResponse GetBuyProperty()
        {
            return new ApiResponse();
        }
        [HttpPost("Create")]
        public ApiResponse CreateProperty(PropertyDto propertyDto)
        {
            return new ApiResponse();
        }
        [HttpPost("Rent")]
        public ApiResponse RentProperty(ContractDto contractDto)
        {
            return new ApiResponse();
        }
        [HttpPost("Buy")]
        public ApiResponse BuyProperty(int id)
        {
            return new ApiResponse();
        }

        [HttpPut("Update")]
        public ApiResponse UpdateProperty(int id, PropertyDto propertyDto)
        {
            return new ApiResponse();
        } 
        [HttpDelete("Remove")]
        public ApiResponse DeleteProperty(int id)
        {
            return new ApiResponse();
        }
    }
}
