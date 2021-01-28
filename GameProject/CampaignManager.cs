using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
       

        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanyalı ürün eklendi. Eklenen kampanyalı ürün:\n"+ campaign.CampaignName);
        }

       
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanyalı ürün silindi. Silinen kampanyalı ürün:\n"+ campaign.CampaignName);
        }

        
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanyalı ürün güncellendi. Güncellenen kampanyalı ürün:\n"+campaign.CampaignName);
        }
    }
}
