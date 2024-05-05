using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using static UnityEditor.Progress;

public class GemPanel : AbstractPanel<GemData>
{
    [SerializeField] GemsDataProvider gemsDataProvider;
    [SerializeField] GemSelectedDataView gemSelectedDataView;

    private  void Start()
    {
        Show(gemsDataProvider);
    }

    public override async void OnDataViewSelected(IDataView<GemData> dataView)
    {
        foreach (var item in dataViewList)
        {
            item.UnSelect();
        }
        dataView.Select();
        GemDataAdditional gemData = await gemsDataProvider.GetData(dataView.Id);
        gemSelectedDataView.Show(gemData);

    }

   


}
