using GameProject.Abstract;
using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Buy(Sale sale, Member member)
        {
            Console.WriteLine(member.FirstName + " " + member.LastName + " isimli kişi" + sale.GameName + " oyununu "+sale.Price + " TL'ye satın almıştır ");
        }
    }
}
