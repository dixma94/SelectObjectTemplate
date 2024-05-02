using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Content contentItems;
    [SerializeField] private Panel panel;

    private void Start()
    {
        panel.Show(contentItems.Items);
    }
}
