using System;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "GemData", menuName = "Scriptable/GemData")]
public class GemData : ScriptableObject, IData
{
    public string Name;
    public Sprite sprite;
    public string Id_Additional { get; set; }
}
