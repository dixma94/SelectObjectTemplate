using TMPro;
using UnityEngine;

public class CDataView : MonoBehaviour, IInitData<CData>
{
    [SerializeField] TextMeshProUGUI Text;
    [SerializeField] TextMeshProUGUI Description;

    public void Init(CData data)
    {
        Text.text = data.Name;
        Description.text = data.Description;
    }
}
