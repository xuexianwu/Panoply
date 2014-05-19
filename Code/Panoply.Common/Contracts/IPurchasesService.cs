using System.Threading.Tasks;

namespace Panoply.Common.Contracts
{
    public interface IPurchasesService
    {
        Task<string> PurchaseProductAsync(string productId);
    }
}