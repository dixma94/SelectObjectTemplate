using System;

public interface ISelectedDataView<T> where T : IData
{
    event Action<IDataView<T>> Selected;
}