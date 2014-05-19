using System;

namespace Panoply.Common.Contracts
{
    public interface ISocialService
    {
        void ShareLink(string title, string message, Uri url);
        void ShareMessage(string message);
        void SendEmail(string subject, string to);
    }
}
