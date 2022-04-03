using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Brans
    {
        public string Ad { get; set; }


        public static List<Brans> BransListesi { get; } =new List<Brans>();


        public override string ToString()
        {
            return Ad;
        }


    }
}
