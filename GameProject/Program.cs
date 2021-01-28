using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1984,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });

            Console.WriteLine("----------------------------------------------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign 
            {
                CampaignName = "X ürününde %20 indirim"
            });

           

        }
    }
}
