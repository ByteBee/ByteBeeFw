using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ByteBee.Extensions;

namespace ByteBee.Configuration.Impl
{
    public class ConfigurationManager : IConfigurationManager
    {
        private IConfigurationStore _store;
        private ConfiguratorRepresentation _representation = new ConfiguratorRepresentation();

        public ConfigurationManager(IConfigurationStore store)
        {
            SetConfigurationStore(store);
        }

        public T Get<T>(string category, string key)
        {
            return _representation.Get<T>(category, key);
        }

        public void Set<T>(string category, string key, T value, bool persist = true)
        {
            _representation.Set(category, key, value, persist);
        }

        public T GetConfig<T>()
        {
            Type configType = typeof(T);
            var config = Activator.CreateInstance<T>();

            PropertyInfo[] properties = configType.GetProperties();

            string category = configType.Name;

            foreach (PropertyInfo property in properties)
            {
                string key = property.Name;

                object value = typeof(ConfiguratorRepresentation)
                    .GetMethod("Get")
                    .MakeGenericMethod(property.PropertyType)
                    .Invoke(_representation, new object[] {category, key});

                property.SetValue(config, value);
            }

            return config;
        }

        public void SetConfigurationStore(IConfigurationStore store)
        {
            _store = store;
        }

        public void Load()
        {
            _representation = _store.Load();
        }

        public void Save()
        {
            _store.Save(_representation.Clone());
        }
    }
}