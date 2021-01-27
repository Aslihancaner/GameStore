using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    public class GamerManager : IGamerService
    {

        public void Add(Gamer entity)
        {
            Console.WriteLine(entity.GamerName + " Added!");
        }

        public void Delete(Gamer entity)
        {
            Console.WriteLine(entity.GamerName + " Deleted!");
        }


        public void Update(Gamer entity)
        {
            Console.WriteLine(entity.GamerName + " Updated!");
        }
    }
}
