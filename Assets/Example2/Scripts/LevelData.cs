using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "Scriptable/LevelData")]
public class LevelData :ScriptableObject, IData
{
    public string Id_Additional { get;  set ; }
    public string Name;
}
