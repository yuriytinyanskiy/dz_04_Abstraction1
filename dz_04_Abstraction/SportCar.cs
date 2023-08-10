using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_04_Abstraction
{
    class SportCar : Car, IMedicalExamination, ITechnicalInspection
    {
        public int MaxSpeed { get; set; }
        public override void Go ()
        {
            Console.WriteLine("Їхати швидко по треку");
        }
        public void Acceleration () 
        {
            Console.WriteLine("Ускоритись");
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
