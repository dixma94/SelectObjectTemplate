using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelDataProvider : MonoBehaviour, IDataProvider<LevelData>
{
    public List<LevelData> data = new List<LevelData>();
    public IEnumerable<LevelData> GetData()
    {
        return data;
    }

    public LevelData GetData(int id)
    {
        LevelData dataItem = data.Where(x => x.Id == id).First();
        return dataItem;
    }
}
