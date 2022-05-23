using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class MernisManager : ICheckIfRealPerson
    {
        public bool checkRealPerson(Musteri musteri)
        {
           KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

           Task<TCKimlikNoDogrulaResponse> resp =  client.TCKimlikNoDogrulaAsync(musteri.TcNo, musteri.FirstName.ToUpper(), musteri.LastName.ToUpper(), musteri.DateOfBirth.Year);
            return resp.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
