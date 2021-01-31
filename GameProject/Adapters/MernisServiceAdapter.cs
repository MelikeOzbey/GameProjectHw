using GameProject.Abstract;
using GameProject.Model;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IMemberValidation
    {
        public bool Verify(Member member)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            //return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
            //    (Convert.ToInt64(member.IdentityNumber), member.FirstName, member.LastName, member.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;

            if (member.FirstName == "Melike" && member.LastName == "Özbey" && member.DateOfBirth.Year == 1994 && member.IdentityNumber == "11111111111")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
