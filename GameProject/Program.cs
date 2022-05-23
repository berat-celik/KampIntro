using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.TcNo = "21604986736";
            gamer1.FirstName = "Berat";
            gamer1.LastName = "Çelik";
            gamer1.DateOfBirth = new DateTime(2001,3,19);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Save(gamer1);
            SatisManager satisManager = new SatisManager();
            satisManager.Sat(gamer1, new KampanyaManager());
        }
    }
}
