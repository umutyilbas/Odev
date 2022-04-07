using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public class Menu : Urun
    {
        public override string Ad { get; set; }
        public override decimal Fiyat { get; set; }

        public Boyutlar Boyut { get; set; }

    

        public override string ToString()
        {
            return Ad + " Menu";
        }



    }
}





