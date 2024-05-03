using UnityEngine;

public interface ICreateDataView<T> where T : IData
{
    public IInitDataView<T> Create(T data);
}
