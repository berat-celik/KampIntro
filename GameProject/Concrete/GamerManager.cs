using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager
    {
        public void Save(Gamer gamer )
        {
            bool check = CheckRealGamer(gamer);
            if (check)
            {
                Console.WriteLine("Veritabanına kaydedildi");

            }
            else
            {
                Console.WriteLine("Geçerli bir kullanıcı değildir");
            }

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi");

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");

        }

        public bool CheckRealGamer(Gamer gamer)
        {
            if (gamer.FirstName.ToUpper()=="BERAT" && gamer.LastName.ToUpper() == "ÇELİK" && gamer.TcNo=="21604986736" && gamer.DateOfBirth.Year==2001)
            {
                return true;

            }
            else
            {
                return false;
            }


        }
    }
}
