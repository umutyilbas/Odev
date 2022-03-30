using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    internal class Ayakkabi:Urun
    {
        public int Numara { get; set; }

        public override string ToString()
        {
             return $"{Marka} {Model} {Numara} {Fiyat.ToString("C2")}";
        }

    }
}
  




 