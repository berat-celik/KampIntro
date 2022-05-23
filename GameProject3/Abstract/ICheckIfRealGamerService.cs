using GameProject3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject3.Abstract
{
    public interface ICheckIfRealGamerService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
