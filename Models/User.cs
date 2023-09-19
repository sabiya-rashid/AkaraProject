using Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : BaseModel
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Email { get; set; }
       public string Phone { get; set; }
       public string Password { get; set; }
       public string Role { get; set; } = "User";
       public ICollection<Property>? Properties { get; set; }
       public ICollection<Contract>? Contracts { get; set; }
       public string Dummy { get; set; }
    }
}
