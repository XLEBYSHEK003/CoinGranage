using System;
using System.ComponentModel;
using Exiled.API.Interfaces;
using Exiled.CustomItems.API;

namespace MagicCoin
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;

		[Description("Item Config")]

		public uint ItemID { get; set; } = 20U;

		public float ItemWeight { get; set; } = 1f;

		public string ItemDescription { get; set; } = "Это <color=#FF18A7>Magic</color> <color=#C518FF>Coin</color>";

		public string DroppedHint { get; set; } = "Ты выбросил MagicCoin";

	}
}
