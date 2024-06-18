using FruitLibrary.Product.Models;
using FruitLibrary.ShopingCart.Models;

namespace FruitLibrary.Storage;

public interface IStorageService
{
    IList<ProductModel> Products { get; }
    public ShoppingCartModel ShoppingCart { get;}
}
