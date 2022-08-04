using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.EntityModels
{
    public class Boat : Vehicle
    {
        public int Length { get; set; }
        public string Material { get; set; }
        public bool Sail { get; set; }
    }
}
