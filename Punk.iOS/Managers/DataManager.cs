using System.Collections.Generic;
using System.Threading.Tasks;
using Punk.iOS.Models;
using System.Net.Http;
using System;
using Newtonsoft.Json;

namespace Punk.iOS.Managers
{
    public class DataManager
	{
		private static DataManager _instance;
		public static DataManager Instance
		{
			get
			{
                if (_instance == null)
				    _instance = new DataManager();

				return _instance;
            }
		}

		readonly HttpClient _httpClient;

        private DataManager()
		{
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.punkapi.com/v2/")
            };
        }

		public async Task<List<Beer>> GetBeerListAsync(int page = 1)
		{
            List<Beer> beers = new List<Beer>();

            try
            {
                var response = await _httpClient.GetAsync("beers?page=" + page);

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    beers = JsonConvert.DeserializeObject<List<Beer>>(jsonContent);
                }
                else
                {
                    Console.WriteLine("Failed to retrieve data: " + response.ReasonPhrase);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            return beers;
		}
    }
}

