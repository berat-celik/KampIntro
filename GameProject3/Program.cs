using GameProject3.Abstract;
using GameProject3.Concrete;
using GameProject3.Entities;
using System;

namespace GameProject3
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Berat";
            gamer1.LastName = "Çelik";
            gamer1.TcNo = "21604986736";
            gamer1.DateOfBirth = new DateTime(2001,3,19);

            IGamerManager gamerManager = new GamerManager(new CheckIfRealGamer());
            gamerManager.Save(gamer1);
            ISatisManager satisManager = new SatisManager(new CampaignManager());
            satisManager.Sat(gamer1);


        }
    }
}
