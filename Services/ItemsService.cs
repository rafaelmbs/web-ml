using AutoMapper;
using System.Threading.Tasks;
using web_ml.Contracts;
using web_ml.Repository.Repositories;

namespace web_ml.Services
{
    public class ItemsService
    {
        private readonly IMapper _mapper;
        private readonly IItemsRepository _itemRepository;

        public ItemsService(IMapper mapper, IItemsRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public async Task<ItemsGetResponse> GetItems(string search)
        {
            var result = await _itemRepository.GetItems(search);

            var response = _mapper.Map<ItemsGetResponse>(result);

            return response;
        }

        public async Task<ItemDetailGetResponse> GetItemDetail(string id)
        {
            var result = await _itemRepository.GetItemDetail(id);

            var response = _mapper.Map<ItemDetailGetResponse>(result);

            return response;
        }

        public async Task<ItemDescriptionGetResponse> GetItemDescription(string id)
        {
            var result = await _itemRepository.GetItemDescription(id);

            return result;
        }
    }
}