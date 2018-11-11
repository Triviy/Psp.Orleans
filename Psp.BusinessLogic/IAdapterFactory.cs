namespace Psp.BusinessLogic
{
    public interface IAdapterFactory
    {
        T Create<T>(string providerAccount) where T : class;
    }
}
