using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Content", menuName = "Shop/Content")]

public class Content : ScriptableObject
{
    [SerializeField] private List<Item> items;

    public IEnumerable<Item> Items => items;
}
