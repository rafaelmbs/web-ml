using System;
using System.Collections.Generic;

namespace web_ml.Repository.Views.Items
{
    public class ResultView
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public SellerView seller { get; set; }
        public double price { get; set; }
        public string currency_id { get; set; }
        public int available_quantity { get; set; }
        public int sold_quantity { get; set; }
        public string buying_mode { get; set; }
        public string listing_type_id { get; set; }
        public DateTime stop_time { get; set; }
        public string condition { get; set; }
        public string permalink { get; set; }
        public string thumbnail { get; set; }
        public bool accepts_mercadopago { get; set; }
        public InstallmentsView installments { get; set; }
        public AddressView address { get; set; }
        public ShippingView shipping { get; set; }
        public SellerAddressView seller_address { get; set; }
        public IList<AttributeView> attributes { get; set; }
        public DifferentialPricingView differential_pricing { get; set; }
        public double? original_price { get; set; }
        public string category_id { get; set; }
        public object official_store_id { get; set; }
        public string catalog_product_id { get; set; }
        public ReviewsView reviews { get; set; }
    }
}