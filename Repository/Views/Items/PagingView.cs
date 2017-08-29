namespace web_ml.Repository.Views.Items
{
    public class PagingView
    {
        public int total { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public int primary_results { get; set; }
    }
}