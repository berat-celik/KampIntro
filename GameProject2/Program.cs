using GameProject2.Abstract;
using GameProject2.Concrete;
using GameProject2.Entities;
using System;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Berat";
            gamer1.LastName = "Çelik";
            gamer1.TcNo = "21604986736";
            gamer1.DateOfBirth = new DateTime(2001, 3, 19);

            IGamerManager gamerManager = new GamerManager(new ChecMernisGamer());
            gamerManager.Save(gamer1);

        }
    }
}
