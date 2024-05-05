using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.AddressableAssets;

public interface IDataProvider<T> where T : IData
{
    IAsyncEnumerable<T> GetData();
}