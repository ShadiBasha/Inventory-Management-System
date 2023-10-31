namespace InventoryManagementSystem;

public class Product : IStorable
{
    private static int _productNumber;
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Product()
    {
        Name = "Product" + _productNumber;
        Quantity = 0;
        _productNumber++;
    }

    public Product(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
        _productNumber++;
    }
}