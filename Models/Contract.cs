using Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
    public class Contract : BaseModel
    {
        public int Id { get; set; }
        public string PropertyId { get; set; }
        public Property Property { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string ContractType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
    }
}
