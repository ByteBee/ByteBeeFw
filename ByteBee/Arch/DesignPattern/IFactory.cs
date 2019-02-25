namespace ByteBee.Arch.DesignPattern
{
    public interface IFactory<out TProduct>
    {
        TProduct Create(string what);
    }
}