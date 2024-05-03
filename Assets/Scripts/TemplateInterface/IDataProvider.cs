using System.Collections.Generic;

public interface IDataProvider<T> where T : IData
{
    IEnumerable<T> GetData();
}