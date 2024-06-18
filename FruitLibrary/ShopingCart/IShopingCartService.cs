using FruitLibrary.Product.Models;
using FruitLibrary.ShopingCart.Models;

namespace FruitLibrary.ShopingCart;

public interface IShopingCartService
{
    ShoppingCartModel Get();
    void AddProduct(ProductModel model , int quantity);
    void DeleteProduct(ShoppingCartItemModel model);
    int CountProduct();
    bool HasProduct(string sku);
}
