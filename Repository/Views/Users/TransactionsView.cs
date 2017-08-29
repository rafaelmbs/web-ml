namespace web_ml.Repository.Views.Users
{
    public class TransactionsView
    {
        public int canceled { get; set; }
        public int completed { get; set; }
        public string period { get; set; }
        public RatingsView ratings { get; set; }
        public int total { get; set; }
    }
}
