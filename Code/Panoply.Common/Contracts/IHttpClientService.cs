using System.Threading.Tasks;

namespace Panoply.Common.Contracts
{
    public interface IHttpClientService
    {
        Task<string> GetStringAsync(string serviceUrl);
    } 
}
