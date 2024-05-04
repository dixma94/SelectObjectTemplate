using TMPro;
using UnityEngine;

public class GemPanel : AbstractPanel<GemData>
{
    [SerializeField] GemsDataProvider gemsDataProvider;
    [SerializeField] GemSelectedDataView gemSelectedDataView;

    private void Start()
    {
        Show(gemsDataProvider);
    }

    public override void OnDataViewSelected(IDataView<GemData> dataView)
    {
        foreach (var item in dataViewList)
        {
            item.UnSelect();
        }
        dataView.Select();
        gemSelectedDataView.Show(gemsDataProvider.GetData(dataView.ID));

    }


}
