using System.Threading.Tasks;
using web_ml.Contracts;
using web_ml.Repository.Views.ItemDetail;
using web_ml.Repository.Views.Items;

namespace web_ml.Repository.Repositories
{
    public interface IItemsRepository
    {
        Task<ResultItemsView> GetItems(string search);

        Task<ResultItemDetailView> GetItemDetail(string id);

        Task<ItemDescriptionGetResponse> GetItemDescription(string id);
    }
}