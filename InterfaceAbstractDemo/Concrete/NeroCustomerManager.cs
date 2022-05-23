using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager:CustomerBaseManager
    {
        ICheckIfRealPerson _checkIfRealPerson;

        public NeroCustomerManager(ICheckIfRealPerson checkIfRealPerson)
        {
            _checkIfRealPerson = checkIfRealPerson;
        }

        public override void Save(Musteri musteri)
        {
            if (_checkIfRealPerson.checkRealPerson(musteri))
            {
                base.Save(musteri);
            }
            else
            {
                Console.WriteLine("Geçersiz kullanici");
            }
            
        }
    }
}
