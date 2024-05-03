public interface IInitData<T> where T : IData
{
    public void Init(T data);
}
