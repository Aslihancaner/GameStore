using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    public class SaleManager : ISaleService
    {
        public void Selling(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName+" isimli oyuncuya satış yapılmıştır");
        }
        public void CampaignSelling(Campaign campaign,Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName+" isimli oyuncuya "+ campaign.CampaignName+" kampanyalı oyun satılmıştır.");
        }
    }
}
