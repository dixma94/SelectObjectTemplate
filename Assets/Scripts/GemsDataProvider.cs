using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GemsDataProvider :MonoBehaviour, IDataProvider<GemData>
{
    public  List<GemData> data = new List<GemData>();
    public IEnumerable<GemData> GetData()
    {
        return data;
    }

    public GemData GetData(int id)
    {
        GemData dataItem = data.Where(x => x.Id == id).First();
        return dataItem;
    }
}