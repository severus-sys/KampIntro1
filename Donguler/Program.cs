using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Kampı";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C++";
            string[] kurslar = new string[]
            {
             "Yazılım Kampı",
             "Temel Kurs",
             "JAVA",
             "Pyhton",
             "C++"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);                
            }

            Console.WriteLine("Sayfa Sonu");
        }

    }


}