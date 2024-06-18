using FruitLibrary.ShopingCart.Models;
using Microsoft.AspNetCore.Components;

namespace Fruite_Ecomerce.Pages;

public partial class ProductListingItem
{

    [Parameter]
    public ShoppingCartItemModel? ShoppingCartItem { get; set; }
}