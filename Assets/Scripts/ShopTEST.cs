using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShopTEST : MonoBehaviour
{
    [SerializeField] private ContenåTEST contentItems;
    [SerializeField] private PanelTEST panel;

    private void Start()
    {
        panel.Show(contentItems.Items);
    }
}
public interface Data
{

}

public interface DataView<T> where T : Data
{
    public void Init(T data);
}

public interface Factory<T> where T : Data
{
    public DataView<T> Create(T data);
}



public class CData : Data
{
    public string Name { get; set; }
    public string Description { get; set; }
}


public class CDataView : DataView<CData>
{
    public void Init(CData data)
    {

    }
}

public class CFactory : Factory<CData>
{
    public DataView<CData> Create(CData data)
    {
        throw new System.NotImplementedException();
    }
}