namespace ODataExpandFilter;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public ProductType ProductType { get; set; }

    public IEnumerable<ProductCategory> ProductCategories { get; set; }
}

public class ProductType
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
}