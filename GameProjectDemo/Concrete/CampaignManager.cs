using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("Kampanya entegre edildi");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Kampanya silindi");

        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Kampanya güncellendi");

        }
    }
}
