using System;
using System.Collections.Generic;
using web_ml.Repository.Views.Users;

namespace web_ml.Contracts
{
    public class UsersGetResponse
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public DateTime registration_date { get; set; }
        public string country_id { get; set; }
        public AddressView address { get; set; }
        public string user_type { get; set; }
        public IList<string> tags { get; set; }
        public object logo { get; set; }
        public int points { get; set; }
        public string site_id { get; set; }
        public string permalink { get; set; }
        public SellerReputationView seller_reputation { get; set; }
        public BuyerReputationView buyer_reputation { get; set; }
        public StatusView status { get; set; }
    }

}
