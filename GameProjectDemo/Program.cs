using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Berat";
            gamer1.LastName = "Çelik";
            gamer1.TcNo = 21604986736;
            gamer1.DateOfBirth = new DateTime(2001,3,19);

            IUserService gamerManager = new GamerManager(new UserValidationMernisManager());
            gamerManager.Save(gamer1);
            IGamerSellService gamerSellManager = new GameSellManager(new CampaignManager());
            gamerSellManager.SellGame(gamer1);
        }
    }
}
