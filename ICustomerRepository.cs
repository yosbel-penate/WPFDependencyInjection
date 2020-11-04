namespace WpfDependencyInjection
{
    public interface ICustomerRepository
    {
        bool Save(object entity);
    }
}