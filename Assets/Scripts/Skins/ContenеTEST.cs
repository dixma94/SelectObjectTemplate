using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Content", menuName = "Shop/Content")]

public class Conten�TEST : ScriptableObject
{
    [SerializeField] private List<ItemTEST> items;

    public IEnumerable<ItemTEST> Items => items;
}
