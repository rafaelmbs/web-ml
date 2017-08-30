using System.Collections.Generic;

namespace web_ml.Repository.Views.Items
{
    public class ResultItemsView
    {
        public string site_id { get; set; }
        public string query { get; set; }
        public PagingView paging { get; set; }
        public IList<ResultView> results { get; set; }
        public IList<object> secondary_results { get; set; }
        public IList<object> related_results { get; set; }
        public SortView sort { get; set; }
        public IList<AvailableSortView> available_sorts { get; set; }
        public IList<FilterView> filters { get; set; }
        public IList<AvailableFilterView> available_filters { get; set; }
    }
}
