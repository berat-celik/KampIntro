using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Concrete
{
    public class ChecRealGamer : IRealCheckGamer
    {
        public bool checkRealGamer(Gamer gamer)
        {
            return false;
        }
    }
}
