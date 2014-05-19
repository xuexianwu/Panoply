using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Panoply.Common.Contracts
{
    public interface ILogInService
    {
        bool SessionStarted { get; }
        Task AuthenticateAsync(string source);
        string GetUserAuthenticatedToken();
        Task LogOut();
        string GetUserAuthenticatedId();
    }
}