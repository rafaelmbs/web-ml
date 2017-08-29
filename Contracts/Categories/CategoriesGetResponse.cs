using System.Collections.Generic;
using web_ml.Repository.Views.Categories;

namespace web_ml.Contracts.Categories
{
    public class CategoriesGetResponse
{
    public string id { get; set; }
    public string name { get; set; }
    public object picture { get; set; }
    public object permalink { get; set; }
    public int total_items_in_this_category { get; set; }
    public IList<PathFromRootView> Path_from_root { get; set; }
    public IList<object> children_categories { get; set; }
    public string attribute_types { get; set; }
    public SettingsView settings { get; set; }
    public int meta_categ_id { get; set; }
    public bool attributable { get; set; }
}
}
