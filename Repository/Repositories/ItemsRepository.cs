using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using web_ml.Contracts.Items;
using web_ml.Repository.Views.Items;
using web_ml.Settings;
using Newtonsoft.Json;

namespace web_ml.Repository.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly IOptions<AppSettings> _config;

        public ItemsRepository(IOptions<AppSettings> config)
        {
            _config = config;
        }

        public async Task<IList<ResultView>> GetItems(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_config.Value.ConnectionURI_APIML);
                var response = await client.GetAsync($"/Items/{id}");
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();
                var rawChart = JsonConvert.DeserializeObject<ItemsGetResponse>(stringResult);
                return rawChart.results;
            }
        }
    }
}