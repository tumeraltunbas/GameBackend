using System;
using System.Collections.Generic;
using System.Text;

namespace Work5
{
    interface IPlayerManager
    {
        void Register(PlayerProp player);
        void Delete(PlayerProp player);
        void Update(PlayerProp player);

    }
}
