using web_ml.Repository.Views.ItemDetail;

namespace web_ml.Contracts
{
    public class ItemDetailGetResponse
    {
        public AuthorView author { get; set; }

        public ItemDetailView item { get; set; }
    }
}