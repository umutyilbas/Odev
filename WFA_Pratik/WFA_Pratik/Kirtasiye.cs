using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Pratik
{
    public class Kirtasiye : Urun,ICrud
    {
        public override string Ad { get ; set ; }
        public override decimal Fiyat { get ; set; }
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
