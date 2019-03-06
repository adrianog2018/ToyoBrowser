using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyoBrowser.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
                
        public ICollection<TrimsLevel> TrimsLevels { get; set; }
    }
}
