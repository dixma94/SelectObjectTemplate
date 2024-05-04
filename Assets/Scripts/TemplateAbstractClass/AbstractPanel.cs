using UnityEngine;

public abstract class AbstractPanel<T> : MonoBehaviour, IShowData<T>
    where T : IData
{
    [SerializeField] protected AbstractFactory<T> factory;
    [SerializeField] protected Transform parent;

    public ICreateDataView<T> GetFactory()
    {
        return factory;
    }

    public void Show(IDataProvider<T> dataProvider)
    {
        foreach (T item in dataProvider.GetData())
        {
            AbstractDataView<T> dataView = GetFactory().Create(item) as AbstractDataView<T>;
            dataView.Init(item);
            dataView.transform.parent = parent;
            dataView.transform.localScale = new Vector3(1, 1, 1);
            dataView.Selected += DataView_Selected;

        }
    }

    private void DataView_Selected(IDataView<T> dataView)
    {
        dataView.Select();
    }

  
}