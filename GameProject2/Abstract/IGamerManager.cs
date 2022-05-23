using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Abstract
{
    public interface IGamerManager
    {
        void Save(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
            
    }
}
