using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using System;

namespace CoinGranageEXILED
{
    internal class EventHandler
    {

        public void OnFlippingCoin(FlippingCoinEventArgs ev) 
        {
            ev.Player.ThrowGrenade(GrenadeType.FragGrenade, true);
        }
    }
}
