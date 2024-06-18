using FruitLibrary.Product.Models;

namespace Fruite_Ecomerce;

public partial class StartPage
{
    public IList<ProductModel>? Products { get; set; }

    protected override void OnInitialized()
    {
        Products = productService.GetAll();
        base.OnInitialized();
    }
}