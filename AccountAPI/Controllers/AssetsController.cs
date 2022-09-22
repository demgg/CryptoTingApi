using AccountAPI.Models.CoinApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Net.Http.Headers;
using System.Web;

namespace AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private static string API_KEY = "74f91c68-9e76-4333-8a3a-d45cdd0c2ea8";

        [HttpGet("GetPeepo")]
        public async Task<List<Coin>> GetPeepo()
        {
            var client = new RestClient("https://rest.coinapi.io/v1/assets");
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("X-CoinAPI-Key", "D06A2E51-68CF-462C-83D2-C63D4EB149D6");

            RestResponse response = client.Execute(request);
            var coin = JsonConvert.DeserializeObject<List<Coin>>(response.Content);
 

            return coin;
        }
    }
}
