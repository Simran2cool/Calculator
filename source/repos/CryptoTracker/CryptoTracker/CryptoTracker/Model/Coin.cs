using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoTracker.Model
{
    class Coin
    {
        public string asset_id { get; set; }
        public string name { get; set; }
        public float price_usd { get; set; }
        public string id_icon { get; set; }
        public string icon_url { get; internal set; }
    }
}
