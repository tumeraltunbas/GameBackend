using System;
using System.Collections.Generic;
using System.Text;

namespace Work5
{
    class PlayerManager: IPlayerManager
    {
        public void Register(PlayerProp player)
        {
            Console.WriteLine(player.FirstName + " Registered");
        }
        public void Delete(PlayerProp player)
        {
            Console.WriteLine(player.FirstName + " Deleted");
        }
        public void Update(PlayerProp player)
        {
            Console.WriteLine(player.FirstName + " Updated");
        }

    }
}
