using System.Collections.Generic;

namespace web_ml.Repository.Views.Items
{
    public class SellerView
    {
        public int id { get; set; }
        public string power_seller_status { get; set; }
        public bool car_dealer { get; set; }
        public bool real_estate_agency { get; set; }
        public IList<object> tags { get; set; }
    }
}