using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Concrete
{
    public class ChecMernisGamer : IRealCheckGamer
    {
        public bool checkRealGamer(Gamer gamer)
        {
            if (gamer.TcNo=="21604986736")
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
