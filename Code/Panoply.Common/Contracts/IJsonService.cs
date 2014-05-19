using System.Threading.Tasks;

namespace Panoply.Common.Contracts
{
    public interface IJsonService
    {
        Task<TData> GetDataAsync<TData>(string serviceUrl);
    }
}
