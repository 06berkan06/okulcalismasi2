using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulcalismasi2
{
    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int ModelYili { get; set; }
        public abstract void Calis();
        public abstract void Dur();
    }
    public class Otomobil : MotorluArac
    {
        public bool OtomatikVites { get; set; }
        public override void Calis()
        {
            Console.WriteLine("Otomobil çalıştı.");
        }
        public override void Dur()
        {
            Console.WriteLine("Otomobil durdu.");
        }
    }
}
