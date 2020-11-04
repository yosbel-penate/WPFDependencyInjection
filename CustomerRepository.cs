namespace WpfDependencyInjection
{
    class CustomerRepository : ICustomerRepository
    {
        public bool Save(object entity)
        {
            return true;
        }
    }
}
