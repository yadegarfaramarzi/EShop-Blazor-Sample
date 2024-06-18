using FruitLibrary.Product.Models;

namespace FruitLibrary.Product;

public interface IProductService
{
    ProductModel? GetProduct(string sku);
    ProductModel? GetProductBySlug(string slug);
    IList<ProductModel> GetAll();
}
