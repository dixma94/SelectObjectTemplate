using System.Collections.Generic;
using UnityEngine;

public interface IShowData<T> where T : IData
{
    void Show(IDataProvider<T> dataProvider);
    ICreateDataView<T> GetFactory();
}
