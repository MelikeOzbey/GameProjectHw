using GameProject.Abstract;
using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campign)
        {
            Console.WriteLine("Kampanya sisteme kayıt edildi.");
        }

        public void Apply(Campaign campaign, Sale sale)
        {
            Console.WriteLine(campaign.CampaignName+"kampanyası satışa uygulanmıştır.");
        }

        public void Delete(int Id)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(int Id)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
