using System.Collections.Generic;
using System.Threading.Tasks;
using web_ml.Contracts.Items;
using web_ml.Repository.Views.Items;

namespace web_ml.Repository.Repositories
{
    public interface IItemsRepository
    {
        Task<ItemsGetResponse> GetItems(string search);

        Task<ItemDetailGetResponse> GetItemDetail(string id);

        Task<ItemDescriptionGetResponse> GetItemDescription(string id);
    }
}