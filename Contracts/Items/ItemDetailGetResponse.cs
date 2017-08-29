using System;
using System.Collections.Generic;
using web_ml.Repository.Views.ItemDetail;

namespace web_ml.Contracts.Items
{
    public class ItemDetailGetResponse
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public object subtitle { get; set; }
        public int seller_id { get; set; }
        public string category_id { get; set; }
        public object official_store_id { get; set; }
        public int price { get; set; }
        public int base_price { get; set; }
        public object original_price { get; set; }
        public string currency_id { get; set; }
        public int initial_quantity { get; set; }
        public int available_quantity { get; set; }
        public int sold_quantity { get; set; }
        public IList<object> sale_terms { get; set; }
        public string buying_mode { get; set; }
        public string listing_type_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime stop_time { get; set; }
        public string condition { get; set; }
        public string permalink { get; set; }
        public string thumbnail { get; set; }
        public string secure_thumbnail { get; set; }
        public IList<PictureView> pictures { get; set; }
        public object video_id { get; set; }
        public IList<DescriptionView> descriptions { get; set; }
        public bool accepts_mercadopago { get; set; }
        public IList<object> non_mercado_pago_payment_methods { get; set; }
        public ShippingView shipping { get; set; }
        public string international_delivery_mode { get; set; }
        public SellerAddressView seller_address { get; set; }
        public object seller_contact { get; set; }
        public LocationView location { get; set; }
        public GeolocationView geolocation { get; set; }
        public IList<object> coverage_areas { get; set; }
        public IList<AttributeView> attributes { get; set; }
        public IList<object> warnings { get; set; }
        public string listing_source { get; set; }
        public IList<object> variations { get; set; }
        public string status { get; set; }
        public IList<object> sub_status { get; set; }
        public IList<string> tags { get; set; }
        public string warranty { get; set; }
        public string catalog_product_id { get; set; }
        public string domain_id { get; set; }
        public object parent_item_id { get; set; }
        public object differential_pricing { get; set; }
        public IList<object> deal_ids { get; set; }
        public bool automatic_relist { get; set; }
        public DateTime date_created { get; set; }
        public DateTime last_updated { get; set; }
    }

}