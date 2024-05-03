public interface IInitDataView<T> where T : IData
{
    public void Init(T data);
}
