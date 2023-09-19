using System;
using Models;

namespace Data.TestData
{
	public class TestData
	{

        public static List<Property> Properties = new List<Property>
        {
            new Property {Id = 1, Name = "Property 1", Description = "This is the description of property 1", Country = "India", State = "Delhi", Type = "Luxurious", Price = 400, BathroomsCount= 4, BedroomsCount= 5, Status = "Rent", Features = "", Verrified = true },
            new Property {Id = 2, Name = "Property 2", Description = "This is the description of property 1", Country = "India", State = "Mumbai", Type = "Semi-Luxurious", Price = 200,  BathroomsCount= 4, BedroomsCount= 5, Status = "Sell", Features = "", Verrified = true},
            new Property {Id = 3, Name = "Property 2", Description = "This is the description of property 1", Country = "India", State = "Mumbai", Type = "Semi-Luxurious", Price = 200,  BathroomsCount= 4, BedroomsCount= 5, Status = "Sell", Features = "", Verrified = false}
        };

        public static List<User> Users = new List<User>
        {
            new User {Id = 1, Name = "user 1", Email = "user1@gmail.com", Password = "123456", Phone = "1234567890", Role = "User" },
            new User {Id = 2, Name = "user 2",Email = "user2@gmail.com", Password = "123456", Phone = "1234567890", Role = "User"  },
            new User {Id = 3, Name = "user 2", Email = "user3@gmail.com", Password = "123456", Phone = "1234567890", Role = "User"}
        };

        //public static List<Contract> Contracts = new List<Contract>
        //{
        //    new Contract {Id = 1, UserId = 1, PropertyId = 1, Price = 400, StartDate = new DateTime(2023, 9, 19), EndDate = new DateTime(2023, 12, 15), ContractType = "Rent", },
        //    new Contract {Id = 2, UserId = 2, PropertyId = 1, Price = 400, StartDate = new DateTime(2023, 9, 19), EndDate = new DateTime(2023, 12, 15), ContractType = "Rent", },
        //};
    }
}

