using FruitLibrary.Product.Models;
using FruitLibrary.ShopingCart.Models;

namespace FruitLibrary.Storage;

public class StorageService : IStorageService
{
    public IList<ProductModel> Products { get; private set; }

    public ShoppingCartModel ShoppingCart { get; private set; }

    public StorageService()
    {
        ShoppingCart = new ShoppingCartModel();
        Products = new List<ProductModel>();
        AddProduct(new ProductModel("1" ,"Grapes" , "img/fruite-item-5.jpg", 1000));
        AddProduct(new ProductModel("2", "Raspberries", "img/fruite-item-2.jpg", 2000));
        AddProduct(new ProductModel("3", "Aprocots", "img/fruite-item-4.jpg", 3000));
        AddProduct(new ProductModel("4", "Bnana", "img/fruite-item-3.jpg", 4000));
        AddProduct(new ProductModel("5", "Orange", "img/fruite-item-1.jpg", 5000));
        AddProduct(new ProductModel("6", "Raspberries", "img/fruite-item-2.jpg", 6000));
        AddProduct(new ProductModel("7", "Grapes", "img/fruite-item-5.jpg", 7000));
        AddProduct(new ProductModel("8", "Orange", "img/fruite-item-1.jpg", 8000));
    }

    private void AddProduct(ProductModel product)
    {
        if (!Products.Any(p=> p.Sku== product.Sku))
        {
            Products.Add(product);
        }
    }
}
