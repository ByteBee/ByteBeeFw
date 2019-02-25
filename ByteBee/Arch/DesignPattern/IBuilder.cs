namespace ByteBee.Arch.DesignPattern
{
    public interface IBuilder<out TProduct>
    {
        void Reset();
        TProduct GetResult();
    }
}