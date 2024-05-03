using UnityEngine;

public class CFactory : MonoBehaviour, ICreateDataView<CData>
{
    [SerializeField] CDataView Prefab;

    public IInitData<CData> Create(CData data)
    {
        return Instantiate(Prefab);
    }
}