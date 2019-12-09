// ReSharper disable UnusedMember.Global
namespace ByteBee.Arch.WellKnown
{
    public interface IVisitable<out TEntity>
    {
        void Accept(IVisitor<TEntity> visitor);
    }
}