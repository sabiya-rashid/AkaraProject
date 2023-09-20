using AutoWrapper.Wrappers;
using Common.DTOs.Contract;
using Common.DTOs.Property;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace AkaraProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet("GetAll")]
        public ApiResponse GetAll()
        {
            return _propertyService.GetAllProperties();
        }
        [HttpGet("Get")]
        public ApiResponse GetProperty(int id)
        {
            return _propertyService.GetProperty(id);
        }
        [HttpGet("GetRent")]
        public ApiResponse GetRentProperty()
        {
            return _propertyService.GetOnRentProperties();
        }
        [HttpGet("GetBuy")]
        public ApiResponse GetBuyProperty()
        {
            return _propertyService.GetOnSellProperties();
        }
        [HttpPost("Create")]
        public ApiResponse CreateProperty(PropertyDto propertyDto)
        {
            return _propertyService.Create(propertyDto);
        }
        [HttpPost("Rent")]
        public ApiResponse RentProperty(ContractDto contractDto, int Id)
        {
            return _propertyService.RentProperty(contractDto, Id);
        }
        [HttpPost("Buy")]
        public ApiResponse BuyProperty(int id)
        {
            return _propertyService.BuyProperty(id);
        }

        [HttpPut("Update")]
        public ApiResponse UpdateProperty(int id, PropertyDto propertyDto)
        {
            return _propertyService.Update(id, propertyDto);
        } 
        [HttpDelete("Remove")]
        public ApiResponse DeleteProperty(int id)
        {
            return _propertyService.Delete(id);
        }
    }
}
