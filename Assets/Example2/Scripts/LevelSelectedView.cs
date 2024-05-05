using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectedView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Name;
    [SerializeField] TextMeshProUGUI Description;
    [SerializeField] Image image;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Show(LevelData levelData)
    {
        gameObject.SetActive(true);
        Name.text = levelData.Name;
        Description.text =levelData.Description;
        image.sprite = levelData.Sprite;
    }
}