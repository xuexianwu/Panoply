using System;

namespace Panoply.Common.Contracts
{
    public interface INetworkService
    {
        event EventHandler NetworkAvailabilityChanged;
        bool IsNetworkAvailable { get; }

        void Initialize();
    }
}
