using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_04_Abstraction
{
    class SportCar : Car, IAcceleration
    {

        public override void Go ()
        {
            Console.WriteLine("Їхати швидко по треку");
        }
        public void IAcceleration () 
        {
            Console.WriteLine("Ускоритись");
        }
    }
}
