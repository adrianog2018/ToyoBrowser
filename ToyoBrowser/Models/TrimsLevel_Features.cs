using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyoBrowser.Models
{
    public class TrimsLevel_Features
    {
        public int TrimsLevelId { get; set; }
        public TrimsLevel TrimsLevel { get; set; }
        public int FeaturesId { get; set; }
        public Features Features { get; set; }
        public bool Standard { get; set; }
    }
}
