using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.EntityModels
{
    public class Car : Vehicle
    {
        public bool HeadlightsState { get; set; }
        public virtual Wheel Wheels { get; set; }
        public string Brand { get; set; }
        public int Model { get; set; }
    }
}
