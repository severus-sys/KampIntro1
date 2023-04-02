using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Ekleniyor...");
            Console.WriteLine("ID : " + musteri.Id);
            Console.WriteLine("İsim : " + musteri.Adi);
            Console.WriteLine("Soyisim : " + musteri.Soyadi);
            Console.WriteLine("Bakiye : " + musteri.Bakiye);
            
        }

        public void MusteriSilme(Musteri musteri){

            Console.WriteLine(musteri.Id + " ID ye sahip Müşteri siliniyor");

        }

        public void MusteriListeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Liste Hazırlınıyor. Bu kadar müsteri var -> " + musteriler.Length);

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("ID : " + musteri.Id);
                Console.WriteLine("İsim : " + musteri.Adi);
                Console.WriteLine("Soyisim : " + musteri.Soyadi);
                Console.WriteLine("Bakiye : " + musteri.Bakiye);
                Console.WriteLine("-------------");
            }

        }




    }
}
