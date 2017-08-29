namespace web_ml.Repository.Views.ItemDetail
{
    public class SellerAddressView
    {
        public string comment { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public CityView city { get; set; }
        public StateView state { get; set; }
        public CountryView country { get; set; }
        public SearchLocationView search_location { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int id { get; set; }
    }
}