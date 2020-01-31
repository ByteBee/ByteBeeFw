using ByteBee.Configuration.Impl;

namespace ByteBee.Configuration
{
    public interface IConfigurationStore
    {
        ConfiguratorRepresentation Load();
        void Save(ConfiguratorRepresentation representation);
    }
}