using System.Collections.Generic;
using UnityEngine;

public class ConcreateDataProvider : IDataProvider<ConcreateData>
{

    public IEnumerable<ConcreateData> GetData()
    {
        List<ConcreateData> cDatas = new List<ConcreateData>();
        cDatas.Add(new ConcreateData { Description = "first", Name = "ffristName" });
        cDatas.Add(new ConcreateData { Description = "Second", Name = "ffristName" });
        cDatas.Add(new ConcreateData { Description = "Thirdd", Name = "1" });
        cDatas.Add(new ConcreateData { Description = "4", Name = "3" });
        cDatas.Add(new ConcreateData { Description = "5", Name = "4" });
        cDatas.Add(new ConcreateData { Description = "6", Name = "5" });

        return cDatas;
    }
}