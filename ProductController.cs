using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace ODataExpandFilter;

public class ProductController : ODataController
{
    private static Product[] _products = new[]
    {
        new Product()
        {
            Id = 1,
            Name = "Product 1",
            ProductType = new ProductType()
            {
                Id = 1,
                Name = "Type 1"
            },
            ProductCategories = new[]
            {
                new ProductCategory() { Id = 1, Name = "Category 1" },
                new ProductCategory() { Id = 2, Name = "Category 2" },
                new ProductCategory() { Id = 3, Name = "Category 3" }
            }
        },
        new Product()
        {
            Id = 2,
            Name = "Product 2",
            ProductType = new ProductType()
            {
                Id = 2,
                Name = "Type 2"
            },
            ProductCategories = new[]
            {
                new ProductCategory() { Id = 2, Name = "Category 2" },
                new ProductCategory() { Id = 3, Name = "Category 3" },
                new ProductCategory() { Id = 4, Name = "Category 4" }
            }
        }
    };

    [HttpGet("products")]
    [EnableQuery]
    public IEnumerable<Product> IndexProducts()
    {
        return _products;
    }
}