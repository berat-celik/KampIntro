using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GameSellManager : IGamerSellService
    {
        ICampaignService _campaignService;

        public GameSellManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void SellGame(Gamer gamer)
        {
            _campaignService.AddCampaign();
            Console.WriteLine("Sayın: "+gamer.FirstName+" oyun satışımız başarıyla gerçekleşmiştir");

        }
    }
}
