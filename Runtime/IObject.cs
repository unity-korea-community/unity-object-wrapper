public interface IObject
{
    object ObjectRaw { get; set; }

    IObject Instantiate();
    U Instantiate<U>(U original) where U : IObject;

    void Destroy();
    void Destroy(IObject obj);
}
