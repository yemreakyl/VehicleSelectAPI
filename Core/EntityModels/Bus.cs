using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.EntityModels
{
    public class Bus:Vehicle
    {
        public int  Capasity { get; set; }
        public int Length { get; set; }
        public virtual Wheel Wheels { get; set; }
    }
}
