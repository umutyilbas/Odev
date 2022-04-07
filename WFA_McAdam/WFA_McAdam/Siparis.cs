using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdam
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        private decimal _fiyat = 0;
        public decimal Fiyat { get
            {  _fiyat = Menu.Fiyat;
                foreach (Ekstra ekstra in Ekstralar)
                {
                    _fiyat += ekstra.Fiyat;

                }
                
                _fiyat *= Adet;
                return _fiyat;
                
            }  }
        public List<Ekstra> Ekstralar { get; set; }
        public byte Adet { get; set; }
        public override string ToString()
        {
            string format = "";
            foreach (Ekstra ekstra in Ekstralar)
            {
                format += ekstra;

            }

            return Menu.Ad + " " + format + " Sipariş Adedi: " + Adet + " Toplam Fiyat: " + Fiyat;
        }




    }
}
