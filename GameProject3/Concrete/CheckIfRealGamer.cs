using GameProject3.Abstract;
using GameProject3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject3.Concrete
{
    public class CheckIfRealGamer : ICheckIfRealGamerService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName.ToUpper()=="BERAT" && gamer.LastName.ToUpper()=="ÇELİK" && (Convert.ToInt64(gamer.TcNo)==21604986736 && gamer.DateOfBirth.Year==2001))
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
