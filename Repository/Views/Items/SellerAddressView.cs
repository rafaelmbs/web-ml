namespace web_ml.Repository.Views.Items
{
    public class SellerAddressView
    {
        public int id { get; set; }
        public string comment { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public CountryView country { get; set; }
        public StateView state { get; set; }
        public CityView city { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
    }
}