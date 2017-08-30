using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using web_ml.Contracts;
using web_ml.Repository.Views.ItemDetail;
using web_ml.Repository.Views.Items;
using web_ml.Settings;

namespace web_ml.Repository.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly IOptions<AppSettings> _config;

        public ItemsRepository(IOptions<AppSettings> config)
        {
            _config = config;
        }

        public async Task<ResultItemsView> GetItems(string search)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_config.Value.ConnectionURI_APIML);
                var response = await client.GetAsync($"{search}");
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultItemsView>(stringResult);
                return result;
            }
        }

        public async Task<ResultItemDetailView> GetItemDetail(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_config.Value.ConnectionURI_APIML);
                var response = await client.GetAsync($"items/{id}");
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultItemDetailView>(stringResult);
                return result;
            }
        }

        public async Task<ItemDescriptionGetResponse> GetItemDescription(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_config.Value.ConnectionURI_APIML);
                var response = await client.GetAsync($"items/{id}/description");
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ItemDescriptionGetResponse>(stringResult);
                return result;
            }
        }
    }
}