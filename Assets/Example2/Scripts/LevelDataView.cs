using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelDataView : AbstractDataView<LevelData>, IPointerClickHandler
{

    [SerializeField] TextMeshProUGUI Name;
    [SerializeField] Image SelectorImage;

    public override string Id { get ; set ; }

    public override void Init(LevelData data)
    {
        Id = data.Id_Additional;
        Name.text = data.Name;
        SelectorImage.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnSelected();
    }

    public override void Select()
    {
        SelectorImage.gameObject.SetActive(true);
    }

    public override void UnSelect()
    {
        SelectorImage.gameObject.SetActive(false);
    }

}
