using OOP3;
using System;
using System.Collections.Generic;

namespace OO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // Yukarıda ki sonuçla aynı interfaceler de implement ettiği sınıfın
            // referans ettiği adresi tutuyor.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            //Log servis listesi yapamadan önce aşşağıdaki kod
            //basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService);

            //liste log ile 
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> { new DataBaseLoggerService(),fileLoggerService});


            List<IKrediManager> krediler =  new List<IKrediManager>()
            {
                ihtiyacKrediManager,tasitKrediManager
            };

            //basvuruManager.KrediOnBilgilendirme(krediler);






        }
    }
}