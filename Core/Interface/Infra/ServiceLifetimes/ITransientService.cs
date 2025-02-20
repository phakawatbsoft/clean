namespace Core.Interface.Infra.ServiceLifetimes
{
    public interface ITransientService
    {
        public int GetRequestedCount();
        public int GetScopedRequestedCount();
        public int GetSingletonRequestedCount();
    }
}