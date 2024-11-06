


using Business.Abstarct;
using Business.Concrete;
using DataAccess.Concrete;

ProductManager productManager = new ProductManager(new ProductDal());
 var dataGeldiMi=productManager.GetAll();

Console.WriteLine(dataGeldiMi);


class Deneme
{
    private readonly IProductService _productService;
    public Deneme(IProductService productService)
    {
        _productService = productService;

        _productService.GetAll();
    }

    
}





