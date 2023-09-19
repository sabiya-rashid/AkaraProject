using Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Property: BaseModel
    {
        public int Id { get; set; } 
        public string Type { get; set; }
        public string Description { get; set;}
        public string Address { get; set; }
        public int Size { get; set; }
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public string Features { get; set;}
        public int UserId { get; set;}
        public User User { get; set; }
        public bool Verrified { get; set; } = false;
        public ICollection<Contract>? Contracts { get; set; }
    }    
}
