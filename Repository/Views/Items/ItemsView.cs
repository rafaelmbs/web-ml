using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_ml.Repository.Views.Items
{
    public class ItemsView
    {
        public string id { get; set; }

        public string title { get; set; }

        public PriceView price { get; set; }

        public string picture { get; set; }

        public string condition { get; set; }

        public bool free_shipping { get; set; }
    }
}
