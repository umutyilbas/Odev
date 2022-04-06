using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Pratik
{
    public abstract class Bilgisayar : Urun
    {
        
        public abstract int Ram { get; set; }
        public abstract string Model { get; set; }

        public abstract string Islemci { get; set; }


    }
}
