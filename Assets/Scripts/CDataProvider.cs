using System.Collections.Generic;
using UnityEngine;

public class CDataProvider : MonoBehaviour, IDataProvider<CData>
{

    public IEnumerable<CData> GetData()
    {
        List<CData> cDatas = new List<CData>();
        cDatas.Add(new CData { Description = "first", Name = "ffristName" });
        cDatas.Add(new CData { Description = "Second", Name = "ffristName" });
        cDatas.Add(new CData { Description = "Thirdd", Name = "1" });
        cDatas.Add(new CData { Description = "4", Name = "3" });
        cDatas.Add(new CData { Description = "5", Name = "4" });
        cDatas.Add(new CData { Description = "6", Name = "5" });

        return cDatas;
    }
}