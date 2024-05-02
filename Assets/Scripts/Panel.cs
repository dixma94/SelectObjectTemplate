using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    private List<ItemView> items = new List<ItemView>();
    [SerializeField] private ItemView itemPrefab;
    [SerializeField] private Transform itemsParent;

    public void Show(IEnumerable<Item> items)
    {
        Clear();
        foreach (Item item in items)
        {
            ItemView spawnedItem = Instantiate(itemPrefab, itemsParent);
            spawnedItem.Initialize(item);
            spawnedItem.Click += OnSpawnedItem_Click;

            spawnedItem.UnSelect();
        }
    }

    private void OnSpawnedItem_Click(ItemView obj)
    {
        if (obj.IsSelected)
        {
            obj.UnSelect();
        }
        else
        {
            obj.Select();
        }
        
    }

    private void Clear()
    {
        foreach(ItemView item in items)
        {
            item.Click-=OnSpawnedItem_Click;
            Destroy(item.gameObject);
        }
        items.Clear();
    }
}
