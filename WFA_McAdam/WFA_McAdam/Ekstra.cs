using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdam
{
    public class Ekstra : Urun
    {
        public override string Ad { get; set ; }
        public override decimal Fiyat { get ; set ; }
        public override string ToString()
        {
            return Ad+" "+Fiyat.ToString("C2");
        }
    }
}
