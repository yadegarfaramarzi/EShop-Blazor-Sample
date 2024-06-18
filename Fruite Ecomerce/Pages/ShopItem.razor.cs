using FruitLibrary.Product.Models;
using Microsoft.AspNetCore.Components;

namespace Fruite_Ecomerce.Pages;

public partial class ShopItem
{
    [Parameter]
    public ProductModel? Product { get; set; }
    public int Quantity { get; set; }

    public void AddToCart()
    {
        if (Product != null)
        {
            shoppingCartService.AddProduct(Product, Quantity);
        }
    }
}