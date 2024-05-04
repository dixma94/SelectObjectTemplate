using System;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "GemData", menuName = "Scriptable/GemData")]
public class GemData : ScriptableObject, IData
{
    public string Name;
    public string Description;
    public GameObject Prefab;
    public Sprite sprite;
    public int id;
    public int Id {get=> id; set => id=value; }
}