using UnityEngine;

public class LevelPanel : AbstractPanel<LevelData>
{
    [SerializeField] LevelDataProvider LevelsDataProvider;
    [SerializeField] LevelSelectedView SelectedDataView;

    private void Start()
    {
        Show(LevelsDataProvider);
    }

    public override void OnDataViewSelected(IDataView<LevelData> dataView)
    {
        foreach (var item in dataViewList)
        {
            item.UnSelect();
        }
        dataView.Select();
        SelectedDataView.Show(LevelsDataProvider.GetData(dataView.ID));

    }

}
