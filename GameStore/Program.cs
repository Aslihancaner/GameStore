using System;
using System.Collections.Generic;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            { 
                GamerName = "Aslıhan",
                GamerBirthDate = "27.07.2001",
                GamerTC = "11111111111"
            };
            GamerManager gamerManager = new GamerManager();

            EDevletInfo eDevletInfo = new EDevletInfo() { TC = "11111111111" };
            if (eDevletInfo.TC == gamer.GamerTC)
            {
                gamerManager.Add(gamer);
            }
            else
            {
                Console.WriteLine("kullanıcı bulunamadı");
            }
            //gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            Campaign campaign = new Campaign()
            {
                Id=1,
                CampaignName="Yeni Yıl İndirimi"
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Selling(gamer);
            saleManager.CampaignSelling(campaign, gamer);


            Console.ReadKey();
        }
    }
}
