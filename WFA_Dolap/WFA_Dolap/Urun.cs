﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public decimal Fiyat { get; set; }
        public string Kategori { get; set; }

        public decimal KDVliFiyat
        {
            get
            {
                return Fiyat * 1.18m;
            }
        }

    }
}
