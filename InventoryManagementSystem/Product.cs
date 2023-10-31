using System.Data.SqlTypes;

namespace InventoryManagementSystem;

public class Product : INullable
{
    public int Quantity { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public bool IsNull { get; set; }
    
    private static int _numberOfProducts;
    
    private int _productNumber;
    
    public Product()
    {
        IsNull = true;
        _productNumber = -1;
        Name = "";
        Price = 0;
        Quantity = 0;
    } 

    public Product(string name, int price, int quantity)
    {
        IsNull = false;
        _productNumber = _numberOfProducts;
        Name = name;
        Price = price;
        Quantity = quantity;
        _numberOfProducts++;
    }

    public override string ToString()
    {
        return $"{_productNumber} : Name : {Name}, Price : {Price}, Quantity: {Quantity}";
    }

}