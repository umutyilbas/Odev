using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Pratik
{
    public class Laptop : Bilgisayar,ICrud
    {
        public override int Ram { get; set; }
        public override string Model { get ; set ; }
        public override string Islemci { get ; set ; }
        public override string Ad { get ; set ; }
        public override decimal Fiyat { get ; set ; }
        public string SarjSuresi { get; set; }
        public string Ekle()
        {
            MessageBox.Show("Urun eklendi");
            return "Urun eklendi";
        }

        public string Guncelle()
        {
            MessageBox.Show("Urun guncellendi");
            return "Urun guncelle";
        }

        public string Kaldir()
        {
            MessageBox.Show("Urun kaldirildi.");
            return "Urun kaldirildi.";
        }

        public string Listele()
        {
            MessageBox.Show("Urun listelendi");
            return "Urun listelendi";
        }

    }
}
