using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_ml.Contracts.Items;
using web_ml.Repository.Repositories;
using web_ml.Repository.Views.Items;
using Newtonsoft.Json;

namespace web_ml.Services
{
    public class ItemsService
    {
        private readonly IItemsRepository _itemRepository;
        public ItemsService(IItemsRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IList<ResultView>> GetItems(string search)
        {
            var result = await _itemRepository.GetItems(search);

            return result;
        }

        public async Task<ItemDetailGetResponse> GetItemDetail(string id)
        {
            var result = await _itemRepository.GetItemDetail(id);

            return result;
        }
    }
}