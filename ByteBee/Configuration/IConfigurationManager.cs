namespace ByteBee.Configuration
{
    public interface IConfigurationManager
    {
        T Get<T>(string category, string key);
        void Set<T>(string category, string key, T value, bool persist = true);
        T GetConfig<T>();
        void SetConfigurationStore(IConfigurationStore store);

        void Load();
        void Save();
    }
}