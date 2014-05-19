namespace Panoply.Common.Contracts
{
    public interface IDependencyContainerService
    {
        T Resolve<T>() where T : class;

        void ResetViewModel<T>() where T : class;
    }
}
