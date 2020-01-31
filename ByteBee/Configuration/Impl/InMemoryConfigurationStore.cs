using ByteBee.Configuration.Exceptions;

namespace ByteBee.Configuration.Impl
{
    public sealed class InMemoryConfigurationStore : IConfigurationStore
    {
        private ConfiguratorRepresentation _memory;

        public ConfiguratorRepresentation Load()
        {
            if (_memory == null)
            {
                throw new MissingConfigurationException();
            }

            return _memory;
        }

        public void Save(ConfiguratorRepresentation representation)
        {
            _memory = representation;
        }
    }
}