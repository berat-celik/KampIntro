using GameProject3.Abstract;
using GameProject3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject3.Concrete
{
    public class CheckIfRealGamerTest : ICheckIfRealGamerService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {

            return true;
        }
    }
}
