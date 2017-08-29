using System.Collections.Generic;

namespace web_ml.Repository.Views.Items
{
    public class ShippingView
    {
        public bool free_shipping { get; set; }
        public string mode { get; set; }
        public IList<object> tags { get; set; }
    }
}