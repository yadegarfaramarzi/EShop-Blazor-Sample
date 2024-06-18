namespace FruitLibrary.Product.Models;

public class ProductModel
{
    public string Sku { get; set; }
    public int Price { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }

    public string Slug
    {
        get
        {
            return Sku.ToLower();
        }
    }
    public string FullUrl
    {
        get
        {
            return string.Format("/product/{0}", Slug);
        }
    }

    public ProductModel()
    {
        Sku = string.Empty;
        Name = string.Empty;
        Image = string.Empty;
    }

    public ProductModel(string sku , string name , string image , int price)
    {
        Sku = sku;
        Name = name;
        Image = image;  
        Price = price;
    }
}