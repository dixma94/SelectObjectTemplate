using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public interface IShowData<T> where T : IData
{
    void Show(IDataProvider<T> dataProvider);
    ICreateDataView<T> GetFactory();
}
