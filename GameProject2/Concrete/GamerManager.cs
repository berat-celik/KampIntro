using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Concrete
{
    public class GamerManager : IGamerManager
    {
        IRealCheckGamer _realCheckGamer;

        public GamerManager(IRealCheckGamer realCheckGamer)
        {
            _realCheckGamer = realCheckGamer;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+ " Silindi");
        }

        public void Save(Gamer gamer)
        {

            if (_realCheckGamer.checkRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName+ " Eklendi");

            }
            else
            {
                Console.WriteLine(gamer.FirstName+ " Geçerli bir kullanıcı değil");

            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Eklendi");

        }
    }
}
