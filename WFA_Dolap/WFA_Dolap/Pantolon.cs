using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Pantolon:Giyim
    {
        public string KumasTuru { get; set; }
        public override string ToString()
        {
            return $"{Marka} {Model} {Renk} {Beden} {KumasTuru} {Fiyat.ToString("C2")}";
        }
    }
}
