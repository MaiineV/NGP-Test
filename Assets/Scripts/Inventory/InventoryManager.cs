using UnityEngine;

public class InventoryManager
{
    private ItemInstance[] _items;

    public InventoryManager(int inventorySize)
    {
        _items = new ItemInstance[inventorySize];
    }

    public bool AddItem(ItemInstance item)
    {
        var emptySlot = _items.GetEmptyIndex();

        if (emptySlot == -1)
        {
            Debug.LogWarning("The Inventory is full");
            return false;
        }
        
        _items[emptySlot] = item;
        return true;
    }

    public void RemoveItem(SO_Item item)
    {
        
    }
}
