using System.Collections;
using System.Collections.Generic;

namespace ToyoBrowser.Models
{
    public class Motor
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public float Cc { get; set; }
        public Brand Brand { get; set; }
        public int? BrandId { get; set; }
        public int? HorsePowers { get; set; }

        public ICollection<TrimsLevel> TrimsLevels { get; set; }
    }
}