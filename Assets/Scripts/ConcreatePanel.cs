public class ConcreatePanel: AbstractPanel<ConcreateData>
{
    private ConcreateDataProvider dataProvider = new ConcreateDataProvider();


    private void Start()
    {
        Show(dataProvider);
    }
}