using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Randevu
    {
        public DateTime Tarih { get; set; }
        public Doktor Doktor { get; set; }
        public Brans Brans { get; set; }
        public string HastaAdi { get; set; }
        public string Tckn { get; set; }
        public string HastaSoyad { get; set; }
        public static List<Randevu> RandevuListesi { get; }=new List<Randevu>();
    }
}
