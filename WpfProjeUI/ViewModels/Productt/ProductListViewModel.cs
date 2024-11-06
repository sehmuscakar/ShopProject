
using Business.Abstarct;
using Business.Concrete;
using DataAccess.Abstarct;
using DataAccess.Concrete;
using Entities.Concrete;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using WpfProjeUI.Views.Category;
namespace WpfProjeUI.ViewModels.Productt
{
    public class ProductListViewModel
    {
        // public ObservableCollection<Product> _list { get; set; }
        // private readonly  IProductDal _productDal1;

        private readonly IProductService _productService;

        public ProductListViewModel(IProductService productService)
        {
            _productService = productService;
        }

        //public ProductListViewModel(IProductDal productDal) //biz bunu aslında viewin kod tarafında çağırıyoruz
        //{
        //   _productDal1=productDal;



        //    OpenNewViewCommand = new RelayCommand(OpenNewView);
        //    DatayıKatmandangetir = new RelayCommand(DataGetir);
        //}
        //   new InstanceFactory<IProductService>().GetInstance();
        //    _list = new ObservableCollection<Product>()
        //{
        //    new Product { Id = 1, Name = "deneme 1", Price = 25 },
        //    new Product { Id = 2, Name = "deneme 2", Price = 30 },
        //    new Product { Id = 3, Name = "deneme 3", Price = 35 }
        //};
        public ICommand OpenNewViewCommand { get; }
        public ICommand DatayıKatmandangetir { get; }
      
        private void OpenNewView()
        {
            MessageBox.Show("Komut çalıştı!"); // Komutun çalıştığını kontrol etmek için
            var newWindow = new CategoryView();
            newWindow.Show();
            // var data = _productDal1.GetAll();
            var data = _productService.GetAll();
        }

        //private void DataGetir()
        //{
        //    _productDal1.GetAll();
        //}

        private void DataGetir()
        {
            _productService.GetAll();
        }
    }
}
