namespace InventoryManagementSystem;

public class Inventory <T> where T : Storable
{
    private List<T>? _storage;

    public Inventory()
    {
        _storage = new List<T>();
    }
    
    public Inventory(List<T> storage)
    {
        _storage = storage;
    }

    public void AddAnItem(T item)
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

    public T GetItemByName(string name)
    {
        T item = _storage.Find(i => i.Name.Equals(name));
        return item;
    }

}