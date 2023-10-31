namespace InventoryManagementSystem;

public class Product : IStorable
{
    private static int _numberOfProuducts;
    public string Name { get; set; }
    public int Quantity { get; set; }

    private int _productNumber;

    public Product()
    {
        _productNumber = _numberOfProuducts;
        Name = "Product" + _productNumber;
        Quantity = 0;
        _numberOfProuducts++;
    }

    public Product(string name, int quantity)
    {
        _productNumber = _numberOfProuducts;
        Name = name;
        Quantity = quantity;
        _numberOfProuducts++;
    }
    public override string ToString()
    {
        return $"{_productNumber} : Name : {Name}, Quantity: {Quantity}";
    }
}