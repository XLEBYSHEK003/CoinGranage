using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CoinGranageEXILED
{
    public class Config : IConfig
    {
        [Description("Plugin CoinGranage is ENABLE?")]
        public bool IsEnabled { get; set; } = true;

    }
}
