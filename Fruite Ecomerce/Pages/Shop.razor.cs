using FruitLibrary.Product.Models;

namespace Fruite_Ecomerce.Pages;

public partial class Shop
{
    public IList<ProductModel>? Products { get; set; }

    protected override void OnInitialized()
    {
        Products = productService.GetAll();
        base.OnInitialized();
    }
}