public interface IGameObject : IObject
{
    bool activeSelf { get; }
    void SetActive(bool active);
}