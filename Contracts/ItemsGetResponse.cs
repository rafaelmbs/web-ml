using System.Collections.Generic;
using web_ml.Repository.Views.Items;

namespace web_ml.Contracts
{
    public class ItemsGetResponse
    {
        public AuthorView author { get; set; }

        public string[] categories { get; set; }

        public IList<ItemsView> items { get; set; }
    }
}