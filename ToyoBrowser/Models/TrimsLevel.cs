using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ToyoBrowser.Models
{
    public class TrimsLevel
    {
        public int Id { get; set; }
        public int? BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int? MotorId { get; set; }
        public Motor Motor { get; set; }
        public int? ModelId { get; set; }
        public Model Model { get; set; }
        public string ModelNumber { get; set; }
        public string TrimPicture { get; set; }

    }
}
