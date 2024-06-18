using FruitLibrary.Product.Models;
using FruitLibrary.ShopingCart.Models;
using FruitLibrary.Storage;

namespace FruitLibrary.ShopingCart;

public class ShopingCartService : IShopingCartService
{
    private readonly IStorageService storageService;
    public ShopingCartService(IStorageService storageService)
    {
        this.storageService = storageService;
    }
    public void AddProduct(ProductModel product, int quantity)
    {
        var items = Get().Items;
        if (HasProduct(product.Sku))
        {
            var item = items.First(i=> i.productModel.Sku == product.Sku);
            item.UpdateQuantity(product, quantity);
        }
        else
        {
            items.Add(new ShoppingCartItemModel(product , quantity));
        }
    }

    public int CountProduct()
    {
        return Get().Items.Count();
    }

    public void DeleteProduct(ShoppingCartItemModel item)
    {
        var items = Get().Items;
        if (HasProduct(item.productModel.Sku))
        {
            items.Remove(items.First(i => i.productModel.Sku == item.productModel.Sku));
        }
    }

    public ShoppingCartModel Get()
    {
        return storageService.ShoppingCart;
    }

    public bool HasProduct(string sku)
    {
        var shoppingCarts = Get();
        return shoppingCarts.Items.Any(i => i.productModel.Equals(sku));
    }
}
