using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {

            krediManager.Hesapla();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.log();

            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();

            }

        }
    }
}
