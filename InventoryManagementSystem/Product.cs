namespace InventoryManagementSystem;

public class Product : IStorable
{
    private static int _numberOfProducts;
    public string Name { get; set; }
    public int Quantity { get; set; }

    private int _productNumber;

    public Product()
    {
        _productNumber = _numberOfProducts;
        Name = "Product" + _productNumber;
        Quantity = 0;
        _numberOfProducts++;
    } 

    public Product(string name, int quantity)
    {
        _productNumber = _numberOfProducts;
        Name = name;
        Quantity = quantity;
        _numberOfProducts++;
    }

    public override string ToString()
    {
        return $"{_productNumber} : Name : {Name}, Quantity: {Quantity}";
    }
}