namespace InventoryManagementSystem;

public class Product : Storable
{
    private static int _numberOfProducts;
    
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