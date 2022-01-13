using UnityEngine;

[System.Serializable]
public abstract class UObject<TWrapped> : UWrapper, IObject
    where TWrapped : Object
{
    [SerializeField]
    private TWrapped wrapped;

    public TWrapped Wrapped
    {
        get => wrapped;
        set => wrapped = value;
    }
    public object ObjectRaw
    {
        get => wrapped;
        set => wrapped = value as TWrapped;
    }

    public void Destroy() => Destroy(this);
    public void Destroy(IObject obj) => Object.Destroy(obj.ObjectRaw as Object);

    public IObject Instantiate() => Instantiate(this);
    public U Instantiate<U>(U original) where U : IObject
    {
        var newWrapper = (U)System.Activator.CreateInstance(original.GetType());
        newWrapper.ObjectRaw = Object.Instantiate(original.ObjectRaw as Object);

        return newWrapper;
    }
}