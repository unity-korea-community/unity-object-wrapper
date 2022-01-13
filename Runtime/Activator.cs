using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField]
    public UGameObject objectToActivate;

    private IGameObject _objectToActivate;
    public IGameObject ObjectToActivate
    {
        get => objectToActivate ?? _objectToActivate;
        set
        {
            objectToActivate = value as UGameObject;
            _objectToActivate = value;
        }
    }

    private void Start()
    {
        ObjectToActivate?.SetActive(true);
    }
}