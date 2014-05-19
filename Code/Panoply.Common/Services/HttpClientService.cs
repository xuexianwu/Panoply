using Panoply.Common.Contracts;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Panoply.Common.Services
{
    public class HttpClientService : IHttpClientService
    {
        public async Task<string> GetStringAsync(string serviceUrl)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(new Uri(serviceUrl));
            }
        }
    }
}
