using System.Data.SqlTypes;

namespace InventoryManagementSystem;

public class Product : INullable
{
    public string Name { get; set; }
    private int _price;
    private int _quantity;
    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0)
                _quantity = 0;
            else
                _quantity = value;
        }
    }
    
    public int Price
    {
        get => _price;
        set
        {
            if (value < 0)
                _price = 0;
            else
                _price = value;
        }
    }

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