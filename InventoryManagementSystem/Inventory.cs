namespace InventoryManagementSystem;

public class Inventory <T>
{
    private List<T>? _storage;

    public Inventory(List<T> storage)
    {
        _storage = storage;
    }

}