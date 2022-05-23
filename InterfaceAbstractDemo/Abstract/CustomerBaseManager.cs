using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class CustomerBaseManager : ICustomerService
    {
        public virtual void Save(Musteri musteri)
        {
            Console.WriteLine("Veritabanına başarıyla kaydedildi");
        }
    }
}
