using System;
using Exiled.API.Features;
using Exiled.Events;

namespace CoinGranageEXILED
{
    internal class Plugin : Plugin<Config>
    {
        public override string Prefix { get; } = "CoinGranage";
        public override string Name { get; } = "CoinGranage";
        public override string Author { get; } = "XLEBYSHEK";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 2);

        internal readonly EventHandler EventHandler = new EventHandler();
        internal readonly Plugin Instance;
        public Plugin()
        {
            Instance = this;
        }

        public override void OnEnabled()
        {
            Log.Info(string.Format("Plugin {0} ({1}) by {2} enabled sucessfully!", Name, Version, Author));
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            Log.Info(string.Format("Plugin {0} ({1}) by {2} disabled sucessfully!!", Name, Version, Author));
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.FlippingCoin += EventHandler.OnFlippingCoin;
        }

        public void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.FlippingCoin -= EventHandler.OnFlippingCoin;
        }
    }
}
