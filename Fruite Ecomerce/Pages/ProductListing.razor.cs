using FruitLibrary.Product.Models;
using FruitLibrary.ShopingCart.Models;

namespace Fruite_Ecomerce.Pages;

public partial class ProductListing
{
    public IList<ShoppingCartItemModel>? ShoppingCart { get; set; }
    protected override void OnInitialized()
    {
        ShoppingCart = ShopingCartService.Get().Items;
        base.OnInitialized();
    }
}