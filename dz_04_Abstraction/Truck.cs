using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_04_Abstraction
{
     class Truck : Car, IUnload, IDownload
    {
        public override void Go ()

        {
            Console.WriteLine("Їхати повільно по з грузом");
        }

        public void IUnload () 
        {
            Console.WriteLine("Розгрузити машину");
        }

        public void IDownload ()
        {
            Console.WriteLine("Загрузити машину");
        }
    }
}
