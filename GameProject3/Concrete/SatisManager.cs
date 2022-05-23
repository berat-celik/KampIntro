using GameProject3.Abstract;
using GameProject3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject3.Concrete
{
    public class SatisManager : ISatisManager
    {
        ICampaignManager _campaignManager;

        public SatisManager(ICampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        public void Guncelle(Gamer gamer)
        {
            Console.WriteLine("Aldığınız ürün güncellendi Sayın: "+gamer.FirstName);
        }

        public void IptalEt(Gamer gamer)
        {
            Console.WriteLine("Aldığınız ürün iptal edildi Sayın: " + gamer.FirstName);

        }

        public void Sat(Gamer gamer)
        {
            _campaignManager.KampanyaGir();
            Console.WriteLine("Ürünü başarıyla satın aldınız Sayın: " + gamer.FirstName);

        }
    }
}
