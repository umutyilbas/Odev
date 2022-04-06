using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdan
{
    public class Hamburger : Urun
    {
        public override string Ad { get ; set ; }
        public override decimal Fiyat { get ; set ; }
        public List<Ekstra> HamburgerEkstras { get; set; }=new List<Ekstra>();
        private decimal _toplamFiyat { get; set; }
        public decimal ToplamFiyat
        {
            get
            {
                
                foreach (Ekstra ekstra in HamburgerEkstras)
                {
                    _toplamFiyat = Fiyat;
                    _toplamFiyat += ekstra.Fiyat;
                    
                }
                   return _toplamFiyat;
            }
        }
        public Boyutlar Boyut { get; set; }
        
             

        public override void Ekle(object nesne)
        {
            Hamburger hamburger = (Hamburger) nesne;
            Listeler.HamburgerListesi.Add(hamburger);
            
        }

        public override void FiyatGuncelle(decimal fiyat)
        {
            Fiyat=fiyat;
        }

        public override void Kaldır(object nesne)
        {
            Hamburger hamburger = (Hamburger)nesne;
            Listeler.HamburgerListesi.Remove(hamburger);

        }
        public override string ToString()
        {
            return Ad;
        }
    }
}
