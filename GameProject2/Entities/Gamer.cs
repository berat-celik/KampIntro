using GameProject2.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
