using DevExpress.Mvvm;
using System.Windows.Input;

namespace WpfDependencyInjection
{
    public class CustomerViewModel : ViewModelBase
    {
        public string Name
        {
            get => GetProperty(() => Name);
            set => SetProperty(() => Name, value);
        }

        public ICommand SaveCommand { get; private set; }
        public IMessageBoxService MessageBoxService => GetService<IMessageBoxService>();

        private ICustomerRepository customerRepository;
        public CustomerViewModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
            SaveCommand = new DelegateCommand(Save, () => !string.IsNullOrWhiteSpace(Name), true);
        }

        private void Save()
        {
            if (customerRepository.Save(new { Name = this.Name }))
                MessageBoxService.ShowMessage("Success!");
        }

    }
}
