using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LevelDataProvider : MonoBehaviour, IDataProvider<LevelData>
{
    public LevelData GetData(string assetGUID)
    {
        throw new System.NotImplementedException();
    }

    IAsyncEnumerable<LevelData> IDataProvider<LevelData>.GetData()
    {
        throw new System.NotImplementedException();
    }

 
}
