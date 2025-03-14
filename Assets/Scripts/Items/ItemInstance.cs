using UnityEngine;

public class ItemInstance : MonoBehaviour
{
    private SO_Item _itemData;

    public int inventoryIndex;
    public bool isOnInventory => inventoryIndex > -1;
}
