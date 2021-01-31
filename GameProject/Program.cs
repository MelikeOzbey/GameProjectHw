using GameProject.Abstract;
using GameProject.Adapters;
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
            Member member = new Member { Id = 1, FirstName = "Melike", LastName = "Özbey", DateOfBirth = new DateTime(1994,1,14), IdentityNumber="11111111111",Password="123" };

            BaseMemberManager memberManager = new MemberManager(new MemberValidationManager());
            memberManager.Add(member);

            BaseMemberManager memberManager2 = new MemberManager(new MernisServiceAdapter());
            memberManager2.Add(member);

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
