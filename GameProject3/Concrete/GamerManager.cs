using GameProject3.Abstract;
using GameProject3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject3.Concrete
{
    public class GamerManager : IGamerManager
    {
        ICheckIfRealGamerService _checkIfRealGamerService;

        public GamerManager(ICheckIfRealGamerService checkIfRealGamerService)
        {
            _checkIfRealGamerService = checkIfRealGamerService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+ " Başarıyla silindi");
        }

        public void Save(Gamer gamer)
        {
            if (_checkIfRealGamerService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " Başarıyla Kayedildi");

            }
            else
            {
                Console.WriteLine("Geçerli bir kullanıcı değil");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Başarıyla güncellendi");

        }
    }
}
