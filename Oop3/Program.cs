using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
      
            IKrediManager konutKrediManager = new KonutKrediManager();

            FileLoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> {fileLoggerService, new DatabaseLoggerService(), new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            


            

        }
    }
}
