using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using ServiceReference;
using System.Threading.Tasks;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class UserValidationMernisManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            Task<TCKimlikNoDogrulaResponse> resp = client.TCKimlikNoDogrulaAsync(gamer.TcNo, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
            return resp.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
