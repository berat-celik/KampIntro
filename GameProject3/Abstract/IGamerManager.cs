using GameProject3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject3.Abstract
{
    public interface IGamerManager
    {
        public void Save(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);

    }
}
