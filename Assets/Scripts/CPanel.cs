using System.Collections.Generic;
using UnityEngine;

public class CPanel : MonoBehaviour, IShowData<CData>
{
    [SerializeField] CFactory factory;
    [SerializeField] Transform parent;
    [SerializeField] CDataProvider provider;


    private void Start()
    {
        Show(GetProvider());
    }

    public IDataProvider<CData> GetProvider()
    {
        return provider;
    }

    public ICreateDataView<CData> GetFactory()
    {
        return factory;
    }

    public void Show(IDataProvider<CData> dataProvider)
    {
        foreach (CData item in dataProvider.GetData())
        {
            CDataView cDataView = GetFactory().Create(item) as CDataView;
            cDataView.Init(item);
            cDataView.transform.parent = parent;
            cDataView.transform.localScale = new Vector3(1, 1, 1);

        }
    }
}