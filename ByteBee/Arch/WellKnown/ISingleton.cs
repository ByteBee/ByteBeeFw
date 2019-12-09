// ReSharper disable UnusedMember.Global
namespace ByteBee.Arch.WellKnown
{
    public interface ISingleton<out TObject>
    {
        TObject GetInstance();
    }
}