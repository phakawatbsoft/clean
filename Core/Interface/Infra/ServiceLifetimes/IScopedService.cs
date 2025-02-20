namespace Core.Interface.Infra.ServiceLifetimes
{
    public interface IScopedService
    {
        public int GetRequestedCount();
    }
}