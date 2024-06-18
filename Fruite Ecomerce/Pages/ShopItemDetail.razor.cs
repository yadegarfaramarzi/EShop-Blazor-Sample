using FruitLibrary.Product.Models;
using Microsoft.AspNetCore.Components;

namespace Fruite_Ecomerce.Pages;

public partial class ShopItemDetail
{
    public ProductModel? product { get; set; }
 
    public int Quantity { get; set; } = 1;

    [Parameter]
    public string Slug { get; set; }

    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(Slug))
        {
            product = productService.GetProductBySlug(Slug);
        }
        base.OnInitialized();
    }

    private void MinusProduct()
    {
        if (Quantity > 0) 
        {
            Quantity = Quantity - 1;
        }
       
    }

    private void PlusProduct()
    {
        Quantity = Quantity+1;
    }

    public void AddToCart()
    {
        if (product!=null)
        {
            shoppingCartService.AddProduct(product, Quantity);
        }
    }
}