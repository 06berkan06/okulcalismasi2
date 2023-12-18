using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulcalismasi2
{
    public class OkulElemanlari
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }
    public class Ogretmen : OkulElemanlari 
    
    {
        public string Brans { get; set; }

    }

}
