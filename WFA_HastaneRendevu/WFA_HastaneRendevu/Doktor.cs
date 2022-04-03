using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Doktor
    {
        public string Ad { get; set; }

        public Brans Brans { get; set; }
        public static List<Doktor> Doktorlar { get; } = new List<Doktor>();
        
        public override string ToString()
        {
            return "Dr. " + Ad;
        }

    }
}
