using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Model;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Üyelik Adımı
            Member member = new Member { Id = 1, FirstName = "Melike", LastName = "Özbey", BirthYear = 1994, IdentityNumber="11111111111",Password="123" };

            MemberValidationManager memberValidationManager = new MemberValidationManager();
            bool validate=memberValidationManager.Verify(member);

            MemberManager memberManager = new MemberManager();
            if(validate==true)
            {
                memberManager.Add(member);
            }
            else
            {
                Console.WriteLine("Lütfen girmiş olduğunuz Ad, Soyad, Doğum Yılı ve TC No bilgilerinin doğruluğunu kontrol ediniz..");
            }

            //Kampanya Ekle-Sil-Güncelle

            Campaign campaign = new Campaign { Id = 1, CampaignName = "Muhteşem haftasonu", Detail = "sepette %50 indirim" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            //campaignManager.Delete(campaign.Id);
            //campaignManager.Update(campaign.Id);

            //Satış ve kampanya

            //1- Üye oyunu seçer
            Sale sale = new Sale { Id = 1, GameName = "LOL", Price = 200 };
            //2- Kampanya seçimi
            if (campaign!=null)
            {
                ICampaignService discountCampaign = new DiscountCampaingManager();
                discountCampaign.Apply(campaign, sale);
            }
            else
            {
                SaleManager saleManager = new SaleManager();
                saleManager.Buy(sale, member);
            }
           

            

           
            
        }
    }
}
