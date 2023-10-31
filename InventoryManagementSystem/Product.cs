namespace InventoryManagementSystem;

public class Product : IStorable
{
    private static int _productNumber;
    public string Name { get; set; } = "Product" + _productNumber;
    public int Quantity { get; set; } = 0;

    public Product()
    {
        _productNumber++;
    }
}