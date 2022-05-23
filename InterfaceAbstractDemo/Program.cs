using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Aleyna";
            musteri1.LastName = "Teke";
            musteri1.TcNo = 21625717326;
            musteri1.DateOfBirth = new DateTime(2002,7,11);

            ICustomerService customerManager = new NeroCustomerManager(new MernisManager());
            customerManager.Save(musteri1);
        }
    }
}
