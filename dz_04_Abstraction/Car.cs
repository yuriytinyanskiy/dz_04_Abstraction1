using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_04_Abstraction
{
    abstract class Car
    {
        public string Producer { get; set; }
        public string Model { get; set; }
                   

        public abstract void Go();
        
    }
}
