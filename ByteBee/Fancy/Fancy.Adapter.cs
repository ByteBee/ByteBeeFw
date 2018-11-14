using ByteBee.Adapter;

namespace ByteBee
{
    public static partial class Fancy
    {
        public static IPath path => Microkernel.Instance.Resolve<IPath>();
        public static IFile file => Microkernel.Instance.Resolve<IFile>();
        public static IGuid guid => Microkernel.Instance.Resolve<IGuid>();
        public static IDateTime dateTime => Microkernel.Instance.Resolve<IDateTime>();
        public static IDirectory directory => Microkernel.Instance.Resolve<IDirectory>();
    }
}