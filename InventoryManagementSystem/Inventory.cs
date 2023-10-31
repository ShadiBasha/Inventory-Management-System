namespace InventoryManagementSystem;

public class Inventory
{
    private List<Product>? _storage;

    public Inventory()
    {
        _storage = new List<Product>();
    }
    
    public Inventory(List<Product> storage)
    {
        _storage = storage;
    }

    public void AddAnItem(Product item)
    {
        _storage?.Add(item);
    }

    public string ViewAllItems()
    {
        var allItems = "";
        if (_storage != null)
            foreach (var item in _storage)
            {
                allItems += item?.ToString() + "\n";
            }
        return allItems;
    }

    public Product GetItemByName(string name)
    {
        foreach (Product item in _storage)
        {
            if (item.Name.Equals(name))
            {
                return item;
            }
        }

        return new Product();
    }

    public void DeletItem(Product item)
    {
        _storage.Remove(item);
    }

}