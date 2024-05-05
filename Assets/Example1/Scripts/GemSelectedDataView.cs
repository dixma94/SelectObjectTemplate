using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class GemSelectedDataView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Name;
    [SerializeField] TextMeshProUGUI Description;
    [SerializeField] Transform prefabPostition;
    private GameObject model;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Show(GemDataAdditional gemData)
    {
        Destroy(model);
        model = Instantiate(gemData.Prefab, prefabPostition);
        gameObject.SetActive(true);
        Name.text = gemData.Name;
        Description.text = "Level: " + gemData.Level.ToString();
    }
}