using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "Scriptable/LevelData")]
public class LevelData :ScriptableObject, IData
{
    public int id;
    public int Id { get => id;  set=> id= value; }
    public string Name;
    public string Description;
    public Sprite Sprite;
}

