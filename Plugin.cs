using System;
using Exiled.API.Features;
using Exiled.CustomItems.API;

namespace MagicCoin
{

	public class Plugin : Plugin<Config>
	{

		public override string Name { get; } = "MagicCoin";

		public override string Prefix { get; } = "MagicCoin";

		public override string Author { get; } = "XLEB_YSHEK";

		public override Version Version { get; } = new Version(1, 2, 0);

		public override Version RequiredExiledVersion { get; } = new Version(5, 2, 2);

		public override void OnEnabled()
		{
			Plugin.Singleton = this;
			Log.Info("MagicCoin Loaded, new Item!!");
			base.OnEnabled();
			this.NukaCola();
		}

		public override void OnDisabled()
		{
			Plugin.Singleton = null;
			base.OnDisabled();
		}

		public void NukaCola()
		{
			magiccoin = new MagicCoin { Type = ItemType.Coin };
			Extensions.Register(this.magiccoin);
		}

		public static Plugin Singleton;
		public MagicCoin magiccoin;
	}
}
