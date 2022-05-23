using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IUserService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" başarıyla silindi");
        }

        public void Save(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName+" başarıyla kaydedildi");

            }
            else
            {
                Console.WriteLine("Geçerli bir kullanıcı değil");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " başarıyla güncellendi");

        }
    }
}
