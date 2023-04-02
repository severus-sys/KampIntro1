using System;
namespace KampIntro
{

    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            //deger tutucu , alias

            string kategoriEtiketi = "Kategori";
            

            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemGiris = true;
            double dolardun = 7.55;
            double dolarbugun = 7.55;

            if (dolardun > dolarbugun)
            {
                Console.WriteLine("AZALIŞ");
            }
            else if (dolardun < dolarbugun)
            {
                Console.WriteLine("ARTIŞ");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemGiris==true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }

    }

}