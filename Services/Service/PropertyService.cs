using AutoWrapper.Wrappers;
using Common.DTOs.Contract;
using Common.DTOs.Property;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.IServices;
using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Claims;

namespace Services.Service
{
    public class PropertyService : IPropertyService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AkaraDbContext _dbContext;

        public PropertyService(AkaraDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _dbContext = dbContext;
        }


        public ApiResponse BuyProperty(int Id)
        {
            Property property = _dbContext.Properties.Where(p => p.Verrified == true).FirstOrDefault(i => i.Id == Id);
            if (property == null)
            {
                return new ApiResponse { Message = "No Property Found" };
            }

            if (property.Status.ToLower() != "on sale")
            {
                return new ApiResponse { Message = "This property is not for sale" };
            }

            Contract contract = new Contract
            {
                StartDate = DateTime.Now,
                Price = property.Price,
                PropertyId = property.Id,
                UserId = int.Parse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(n => n.Type == ClaimTypes.NameIdentifier).Value),
                ContractType = "Sold"
            };
            property.Status = "Sold";
            _dbContext.Contracts.Add(contract);
            _dbContext.SaveChanges();
            return new ApiResponse { Result = contract };
        }
    

        public ApiResponse Create(PropertyDto PropertyDto)
        {
            Property property = new Property
            {
                Type = PropertyDto.Type,
                Name = PropertyDto.Name,
                Description = PropertyDto.Description,
                Country = PropertyDto.Country,
                State = PropertyDto.State,
                Size = PropertyDto.Size,
                BedroomsCount = PropertyDto.BedroomsCount,
                BathroomsCount = PropertyDto.BathroomsCount,
                Price = PropertyDto.Price,
                Status = PropertyDto.Status,
                Features = PropertyDto.Features,
                UserId = int.Parse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(n => n.Type == ClaimTypes.NameIdentifier).Value)
            };

            _dbContext.Properties.Add(property);
            _dbContext.SaveChanges();
            return new ApiResponse { Message = "Property Created. It will be listed once verified by the Admin", Result = property };
        }

        public ApiResponse Delete(int id)
        {
            var property = _dbContext.Properties.Find(id);
            if (property == null)
            {
                return new ApiResponse { Message = "No Property Found" };
            }
            _dbContext.Remove(property);
            _dbContext.SaveChanges(true);
            return new ApiResponse { Message = "Property deleted successfully" };
        }

        public ApiResponse GetAllProperties()
        {
            IQueryable<Property> properties = _dbContext.Properties.Where(p=>p.Verrified == true);

            return new ApiResponse { Result = properties };
        }

        public ApiResponse GetOnRentProperties()
        {
            IQueryable<Property> propertiesOnRent = _dbContext.Properties.Where(p => p.Status.ToLower() == "on rent").Where(p => p.Verrified == true);

            return new ApiResponse { Result = propertiesOnRent };
        }

        public ApiResponse GetOnSellProperties()
        {
            IQueryable<Property> propertiesOnSale = _dbContext.Properties.Where(p => p.Status.ToLower() == "on sale").Where(p => p.Verrified == true);

            return new ApiResponse { Result = propertiesOnSale };
        }

        public ApiResponse GetProperty(int Id)
        {
            Property property = _dbContext.Properties.Where(p => p.Verrified == true).FirstOrDefault(i=>i.Id == Id);
            if(property == null)
            {
                return new ApiResponse { Message = "No Property Found"};
            }
            return new ApiResponse { Result = property };
        }

        public ApiResponse RentProperty(ContractDto contractDto, int Id)
        {
            Property property= _dbContext.Properties.Find(Id);
            if (property == null)
            {
                return new ApiResponse { Message = "No Property Found" };
            }

            if(property.Status.ToLower() != "on rent")
            {
                return new ApiResponse { Message = "This property is not for rent" };
            }

            Contract contract = new Contract
            {
                StartDate = contractDto.StartDate,
                EndDate = contractDto.EndDate,
                Price = property.Price,
                PropertyId = property.Id,
                UserId = int.Parse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(n => n.Type == ClaimTypes.NameIdentifier).Value),
                ContractType = "Rented"
            };
            property.Status = "Rented";
            _dbContext.Contracts.Add(contract);
            _dbContext.SaveChanges();
            return new ApiResponse { Result = contract };
        }

        public ApiResponse Update(int Id, PropertyDto propertyDto)
        {
            var property = _dbContext.Properties.Find(Id);
            if (property == null)
            {
                return new ApiResponse { Message = "No Property Found" };
            }
            property.Type = propertyDto.Type;
            property.Name = propertyDto.Name;
            property.Description = propertyDto.Description;
            property.Country = propertyDto.Country;
            property.State = propertyDto.State;
            property.Size = propertyDto.Size;
            property.BedroomsCount = propertyDto.BedroomsCount;
            property.BathroomsCount = propertyDto.BathroomsCount;
            property.Price = propertyDto.Price;
            property.Status = propertyDto.Status;
            property.Features = propertyDto.Features;
            _dbContext.SaveChanges();
            return new ApiResponse() { Result = property, Message ="Property updated successfully"}; 
        }
    }
}

