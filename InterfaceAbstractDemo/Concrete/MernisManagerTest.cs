using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class MernisManagerTest : ICheckIfRealPerson
    {
        public bool checkRealPerson(Musteri musteri)
        {
            return true;
        }
    }
}
