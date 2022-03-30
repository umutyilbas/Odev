using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Tshirt:Giyim
    {
        public override string ToString()
        {
            return $"{Marka} {Model} {Renk} {Beden} {Fiyat.ToString("C2")}";
        }
    }
}
