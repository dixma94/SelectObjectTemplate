using UnityEngine;

[CreateAssetMenu(fileName ="SkinItem", menuName ="Shop/SkinItem")]
public class ItemTEST : ScriptableObject
{
    [field:SerializeField] public GameObject Model {  get; private set; }
    [field:SerializeField] public Sprite Image {  get; private set; }
    [field: SerializeField] public string Text { get; private set; }
    [field:SerializeField, Range(0,1000)] public int Price {  get; private set; }
   

}
