using GameProject3.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject3.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void KampanyaGir()
        {
            Console.WriteLine("Kampanya uygulandı");
        }

        public void KampanyaGuncelle()
        {
            Console.WriteLine("Kampanya Guncellendi");

        }

        public void KampanyaSil()
        {
            Console.WriteLine("Kampanya Silindi");

        }
    }
}
