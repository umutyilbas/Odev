using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdan
{
    public abstract class Urun:BaseClass
    {
        public abstract string Ad { get; set; }
        public abstract decimal Fiyat { get; set; }
    }
}
