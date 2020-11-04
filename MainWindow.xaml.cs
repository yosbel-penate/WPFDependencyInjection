using System.Windows;
using Unity;

namespace WpfDependencyInjection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.Resolve<CustomerViewModel>();

            var customerView = container.Resolve<CustomerView>();
            content.Children.Add(customerView);

        }
    }
}
