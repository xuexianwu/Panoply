namespace Panoply.Common.Contracts
{
    public interface ITimerService
    {
        void StartGameTimer();
        void StopGameTimer();
        void StartPenaltyTimer();
    }
}
