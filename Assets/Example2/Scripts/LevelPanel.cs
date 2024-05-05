using UnityEngine;

public class LevelPanel : AbstractPanel<LevelData>
{
    [SerializeField] LevelDataProvider LevelsDataProvider;
    [SerializeField] LevelSelectedView SelectedDataView;

    private void Start()
    {
        Show(LevelsDataProvider);
    }

    public override async void OnDataViewSelected(IDataView<LevelData> dataView)
    {
        foreach (var item in dataViewList)
        {
            item.UnSelect();
        }
        dataView.Select();
        LevelDataAdditional levelData =  await LevelsDataProvider.GetData(dataView.Id);
        SelectedDataView.Show(levelData);

    }

}
