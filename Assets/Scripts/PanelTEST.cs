using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTEST : MonoBehaviour
{
    private List<ItemViewTEST> items = new List<ItemViewTEST>();
    [SerializeField] private ItemViewTEST itemPrefab;
    [SerializeField] private Transform itemsParent;

    public void Show(IEnumerable<ItemTEST> items)
    {
        Clear();
        foreach (ItemTEST item in items)
        {
            ItemViewTEST spawnedItem = Instantiate(itemPrefab, itemsParent);
            spawnedItem.Initialize(item);
            spawnedItem.Click += OnSpawnedItem_Click;

            spawnedItem.UnSelect();
        }
    }

    private void OnSpawnedItem_Click(ItemViewTEST obj)
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
        foreach(ItemViewTEST item in items)
        {
            item.Click-=OnSpawnedItem_Click;
            Destroy(item.gameObject);
        }
        items.Clear();
    }
}
