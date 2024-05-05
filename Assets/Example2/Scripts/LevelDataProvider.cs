using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LevelDataProvider : MonoBehaviour, IDataProvider<LevelData>
{
    public List<Asset> data = new List<Asset>();

    public async IAsyncEnumerable<LevelData> GetData()
    {
        foreach (var asset in data)
        {
            LevelData gemData = await asset.data.LoadAssetAsync<LevelData>().Task;
            gemData.Id_Additional = asset.dataAdditional.AssetGUID;
            yield return gemData;
        }
    }

    public Task<LevelDataAdditional> GetData(string assetGUID)
    {
        return Addressables.LoadAssetAsync<LevelDataAdditional>(assetGUID).Task;
    }

}
