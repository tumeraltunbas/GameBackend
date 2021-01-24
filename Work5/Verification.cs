using System;
using System.Collections.Generic;
using System.Text;

namespace Work5
{
    class Verification: IVerification
    {
        public void Verify(PlayerProp player)
        {
            Console.WriteLine(player.Id + " " + "verified via e-devlet.");
        }
    }
}
