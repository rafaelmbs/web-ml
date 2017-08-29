using System.Collections.Generic;

namespace web_ml.Repository.Views.Items
{
    public class ValueView
    {
        public string id { get; set; }
        public string name { get; set; }
        public IList<PathFromRootView> path_from_root { get; set; }
    }
}