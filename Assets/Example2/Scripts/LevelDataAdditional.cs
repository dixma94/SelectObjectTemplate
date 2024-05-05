using UnityEngine;

[CreateAssetMenu(fileName = "LevelDataAdditional", menuName = "Scriptable/LevelDataAdditional")]
public class LevelDataAdditional : ScriptableObject, IData
{
    public string Id_Additional { get; set; }
    public string Name;
    public string Description;
    public Sprite Sprite;
}
