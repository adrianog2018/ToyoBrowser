using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ToyoBrowser.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public Model Model { get; set; }
        public int ModelId { get; set; }
        public VehicleClass VehicleClass { get; set; }
        public int VehicleClassId { get; set; }
        public string ImageUrl { get; set; }
    }
}
