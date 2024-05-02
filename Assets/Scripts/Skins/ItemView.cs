using System;
using System.Security;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemView : MonoBehaviour, IPointerClickHandler
{
    public event Action<ItemView> Click;



    [SerializeField] private Image contentImage;

    [SerializeField] private Image selectionText;

    [SerializeField] private TextMeshProUGUI Text;

    public Item Item { get; private set; }

    public GameObject Model => Item.Model;

    public bool IsSelected = false;

    public void Initialize(Item item)
    {
       
        Item = item;
        contentImage.sprite = item.Image;
        Text.text = item.Text;

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Click?.Invoke(this);
    }

    public void Select()
    {
        selectionText.gameObject.SetActive(true);
        IsSelected = true;
    }

    public void UnSelect()
    {
        selectionText.gameObject.SetActive(false);
        IsSelected= false;
    }

    
}
