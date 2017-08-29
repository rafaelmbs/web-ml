using System;
using web_ml.Repository.Views.ItemDescription;

namespace web_ml.Contracts.Items
{
    public class ItemDescriptionGetResponse
    {
        public string text { get; set; }
        public string plain_text { get; set; }
        public DateTime last_updated { get; set; }
        public DateTime date_created { get; set; }
        public SnapshotView snapshot { get; set; }
    }
}
