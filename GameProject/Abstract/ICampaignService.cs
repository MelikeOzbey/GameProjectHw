using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campign);
        void Update(int Id);
        void Delete(int Id);
        void Apply(Campaign campaign, Sale sale);
    }
}
