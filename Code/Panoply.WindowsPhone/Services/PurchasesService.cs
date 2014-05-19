using Panoply.Common.Contracts;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store;

namespace Panoply.Services
{
    public class PurchasesService : IPurchasesService
    {
        public async Task<string> PurchaseProductAsync(string productId)
        {
            try
            {
                string purchaseResult = await CurrentApp.RequestProductPurchaseAsync(productId, false);
                return purchaseResult;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}