using UnityEngine;

public interface ICreateDataView<T> where T : IData
{
    public IInitData<T> Create(T data);
}
