using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdan
{
    public abstract class BaseClass
    {
        public abstract void Ekle(object nesne);
        public abstract void FiyatGuncelle(decimal fiyat);
        public abstract void Kaldır(object nesne);
        
    }
}
