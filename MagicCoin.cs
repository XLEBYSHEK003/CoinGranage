using System;
using System.Collections.Generic;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs;
using Exiled.CustomItems.API;


namespace MagicCoin
{
	[CustomItem(ItemType.Coin)]
	public class MagicCoin : CustomItem
	{
        public override uint Id { get; set; } = Plugin.Singleton.Config.ItemID;
        public override string Name { get; set; } = "MagicCoin";
        public override string Description { get; set; } = Plugin.Singleton.Config.ItemDescription;
        public override float Weight { get; set; } = Plugin.Singleton.Config.ItemWeight;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties
        {
            Limit = 3,
            DynamicSpawnPoints = new List<DynamicSpawnPoint>
            {
                new DynamicSpawnPoint
                {
                    Chance = 100,
                    Location = SpawnLocation.InsideGr18,
                },
                new DynamicSpawnPoint
                {
                    Chance = 100,
                    Location = SpawnLocation.InsideGateA,
                },
                new DynamicSpawnPoint
                {
                    Chance = 100,
                    Location = SpawnLocation.InsideGateB,
                },
            },
        };
        protected override void SubscribeEvents()
        {
            base.SubscribeEvents();
            Exiled.Events.Handlers.Player.FlippingCoin+= OnFlippingCoin;
        }
        protected override void UnsubscribeEvents()
        {
            base.UnsubscribeEvents();
            Exiled.Events.Handlers.Player.FlippingCoin -= OnFlippingCoin;
        }
        public void OnFlippingCoin(FlippingCoinEventArgs ev) 
        {
            if (Check(ev.Player)) 
            {
                ev.Player.EnableEffect(Exiled.API.Enums.EffectType.Visuals939, 5);
                ev.Player.EnableEffect(Exiled.API.Enums.EffectType.MovementBoost, 10);
                ev.Player.EnableEffect(Exiled.API.Enums.EffectType.Invisible, 3);
                ev.Player.AddAhp(-15);
                ev.Player.Broadcast(3, "!Ты использовал MagicCoin!", Broadcast.BroadcastFlags.Normal, true);       
            }
        }

    }
}
