using System;
using AutoWrapper.Wrappers;
using Common.DTOs.Contract;
using Common.DTOs.Property;

namespace Services.IServices
{
	public interface IPropertyService
	{
        ApiResponse GetAllProperties();
        ApiResponse GetProperty(int Id);
        ApiResponse Create(PropertyDto PropertyDto);
        ApiResponse BuyProperty(int Id);
        ApiResponse RentProperty(ContractDto ContractDto);
        ApiResponse GetOnRentProperties();
        ApiResponse GetOnSellProperties();
        ApiResponse Delete(int id);
        ApiResponse Update(int Id, PropertyDto PropertyDto);
    }
}

