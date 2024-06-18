using FruitLibrary.Product.Models;

namespace FruitLibrary.ShopingCart.Models;

public class ShoppingCartItemModel
{
    public ProductModel productModel { get; }
    public int Price { get; protected set; }
    public int Quantity { get; protected set; }
    public int TotalPrice
    {
        get
        {
            return Price * Quantity;
        }

    }

    public ShoppingCartItemModel(ProductModel product, int quantity)
    {
        productModel = product;
        Quantity = quantity;
        Price = product.Price;

    }

    public void UpdateQuantity(ProductModel product, int quantity)
    {
        Quantity = quantity;
        Price = product.Price;
    }
}
