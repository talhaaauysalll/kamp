﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { 
                ihtiyacKrediManager,tasitKrediManager,konutKrediManager
            };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //Interfaceler birbirinin alternatifi olan işlemler classlar için kullanılır.

        }
    }
}
