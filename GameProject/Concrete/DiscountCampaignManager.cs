using GameProject.Abstract;
using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class DiscountCampaingManager:ICampaignService
    {
        public void Add(Campaign campign)
        {
            Console.WriteLine("İndirimli Kampaya Kaydedildi");
        }

        public void Apply(Campaign campaign, Sale sale)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası " +campaign.Detail+ " olacak şekilde "+sale.GameName +" satışına uygulanmıştır.");
        }

        public void Delete(int Id)
        {
            Console.WriteLine("İndirimli Kampaya Silindi");
        }

        public void Update(int Id)
        {
            Console.WriteLine("İndirimli Kampaya Güncellendi.");
        }
    }
}
