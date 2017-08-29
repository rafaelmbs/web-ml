using System.Collections.Generic;

namespace web_ml.Repository.Views.ItemDetail
{
    public class ShippingView
    {
        public string mode { get; set; }
        public IList<FreeMethodView> free_methods { get; set; }
        public IList<string> tags { get; set; }
        public object dimensions { get; set; }
        public bool local_pick_up { get; set; }
        public bool free_shipping { get; set; }
        public string logistic_type { get; set; }
        public bool store_pick_up { get; set; }
    }
}