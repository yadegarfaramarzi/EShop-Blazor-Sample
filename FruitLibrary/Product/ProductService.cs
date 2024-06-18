using FruitLibrary.Product.Models;
using FruitLibrary.Storage;

namespace FruitLibrary.Product;

public class ProductService : IProductService
{
    private readonly IStorageService storageService;

    public IList<ProductModel> GetAll()
    {
        return storageService.Products.ToList();
    }

    public ProductModel? GetProduct(string sku)
    {
        return storageService.Products.FirstOrDefault(x=> x.Sku == sku);
    }

    public ProductModel? GetProductBySlug(string slug)
    {
        return storageService.Products.FirstOrDefault(x=> x.Slug == slug);
    }
    public ProductService(IStorageService storageService)
    {
        this.storageService = storageService;
    }
}
