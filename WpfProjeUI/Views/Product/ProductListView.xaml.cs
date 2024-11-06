using Business.Abstarct;
using Business.Concrete;
using DataAccess.Concrete;
using System.Windows;
using WpfProjeUI.ViewModels.Productt;
using WpfProjeUI.Views.Category;

namespace WpfProjeUI.Views.Product
{
    /// <summary>
    /// Interaction logic for ProductListView.xaml
    /// </summary>
    public partial class ProductListView : Window
    {
        public ProductListView()
        {
            InitializeComponent(); // sen burdda direk sınıfa bağlanamazsın 
                                   //var manager = new ProductManager();
                                   //manager.GetAll
                                   //this.DataContext = new ProductListViewModel(); // ViewModel'i bağla
            var newWindow = new CategoryView();
            MessageBox.Show("Komut Çalıştı.");
            newWindow.Show();
        }
    }
}
