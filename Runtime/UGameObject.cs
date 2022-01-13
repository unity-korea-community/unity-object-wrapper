using UnityEngine;

[System.Serializable]
public class UGameObject : UObject<GameObject>, IGameObject
{
    public bool activeSelf => Wrapped.activeSelf;

    public void SetActive(bool active)
        => Wrapped.SetActive(active);
}