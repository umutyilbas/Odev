using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdan
{
    public class Ekstra : Urun
    {
        public override string Ad { get ; set ; }
        public override decimal Fiyat { get ; set; }

        public override void Ekle(object nesne)
        {
            Ekstra ekstra = (Ekstra) nesne;
            Listeler.EkstraListe.Add(ekstra);
        }

        public override void FiyatGuncelle(decimal fiyat)
        {
            Fiyat= fiyat;
        }

        public override void Kaldır(object nesne)
        {
            Ekstra ekstra = (Ekstra)nesne;
            Listeler.EkstraListe.Remove(ekstra);
        }
        public override string ToString()
        {
            return Ad;
        }
    }
}
