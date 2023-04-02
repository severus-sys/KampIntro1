using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi  : " + urun.Adi);
        }
        
        public void Ekle2(string urunAdı,string aciklama,double fiyat,int stok)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi " +urunAdı );
        }

    }   

}
