using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.Property
{
    public class PropertyDto
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int Size { get; set; }
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public string Features { get; set; }
    }
}
