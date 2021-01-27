using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    public class CampaignManager : ICampaignService
    {
       
        public void Add(Campaign entity)
        {
            Console.WriteLine(entity.CampaignName + " Added!");
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine(entity.CampaignName + " Deleted!");
        }


        public void Update(Campaign entity)
        {
            Console.WriteLine(entity.CampaignName + " Updated!");
        }
    }
}
