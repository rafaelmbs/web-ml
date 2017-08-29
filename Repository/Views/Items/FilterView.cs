using System.Collections.Generic;

namespace web_ml.Repository.Views.Items
{
    public class FilterView
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public IList<ValueView> values { get; set; }
    }
}