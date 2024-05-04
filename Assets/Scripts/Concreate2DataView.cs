using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Concreate2DataView : AbstractDataView<ConcreateData>, IPointerClickHandler
{
    [SerializeField] TextMeshProUGUI Text;
    [SerializeField] TextMeshProUGUI Description;

    public override void Init(ConcreateData data)
    {
        Text.text = data.Name;
        Description.text = data.Description;
        Description.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnSelected();
    }

    public override void Select()
    {
        Description.gameObject.SetActive(true);
    }
}
