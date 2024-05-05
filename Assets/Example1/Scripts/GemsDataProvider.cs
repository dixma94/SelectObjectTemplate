using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class GemsDataProvider :MonoBehaviour, IDataProvider<GemData>
{
    
    public  List<Asset> data = new List<Asset>();

    public async IAsyncEnumerable<GemData> GetData()
    {
        foreach (var asset in data)
        {
            GemData gemData = await asset.data.LoadAssetAsync<GemData>().Task;
            gemData.Id_Additional = asset.dataAdditional.AssetGUID;
            yield return gemData;
        }
    }

    public Task<GemDataAdditional> GetData(string assetGUID)
    {
        return Addressables.LoadAssetAsync<GemDataAdditional>(assetGUID).Task;
    }
}
