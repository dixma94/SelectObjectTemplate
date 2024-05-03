using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class CDataView : MonoBehaviour, IInitDataView<CData>, IPointerClickHandler, ISelectable
{
    [SerializeField] TextMeshProUGUI Text;
    [SerializeField] TextMeshProUGUI Description;

    public event Action<ISelectable> Selected;

    public void Init(CData data)
    {
        Text.text = data.Name;
        Description.text = data.Description;
        Description.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Selected?.Invoke(this);
    }

    public void Select()
    {
        Description.gameObject.SetActive(true);
    }
}
