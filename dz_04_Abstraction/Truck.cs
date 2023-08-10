using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_04_Abstraction
{
     class Truck : Car, IMedicalExamination, ITechnicalInspection
    {

        public int LiftingCapacity { get; set; }

        public override void Go ()

        {
            Console.WriteLine("Їхати повільно по з грузом");
        }

        public void Unload () 
        {
            Console.WriteLine("Розгрузити машину");
        }

        public void Download ()
        {
            Console.WriteLine("Загрузити машину");
        }

        public void ConductATechnicalInspection()
        {
            Console.WriteLine("Провести техогляд автомобілю");
        }

        public void ConductAMedicalExamination()
        {
            Console.WriteLine("Провести медогляд водія");
        }
    }
}
