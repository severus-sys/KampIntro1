using System;

namespace Odev3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("------Hoşgeldiniz-------");

            //add musteri objects
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Bakiye = 10000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Can";
            musteri2.Soyadi = "Şimşek";
            musteri2.Bakiye = 15000;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Su";
            musteri3.Soyadi = "Demir";
            musteri3.Bakiye = 5000;


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkleme(musteri1);

            Console.WriteLine("---------------");
            
            musteriManager.MusteriSilme(musteri2);

            Console.WriteLine("----------------");

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3 };

            musteriManager.MusteriListeleme(musteriler);

           






        }

    }

}