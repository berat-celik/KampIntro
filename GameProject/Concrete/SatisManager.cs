using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SatisManager
    {
        public void Sat(Gamer gamer,KampanyaManager kampanyaManager)
        {
            kampanyaManager.KampanyaGirisi();
            Console.WriteLine("Satıldı");
        }

    }
}
