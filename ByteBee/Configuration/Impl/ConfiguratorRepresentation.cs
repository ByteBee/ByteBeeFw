using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;

namespace ByteBee.Configuration.Impl
{
    public sealed class ConfiguratorRepresentation
    {
        private const char KeySeparator = '\x1337';

        private Dictionary<string, object> _memory =
            new Dictionary<string, object>();

        private static string CreateKey(string category, string key)
        {
            return $"{category}{KeySeparator}{key}";
        }

        public T Get<T>(string category, string key)
        {
            string index = CreateKey(category, key);

            if (TryParse<T>(_memory[index], out object output))
            {
                return (T)output;
            }

            return default;
        }

        private bool TryParse<T>(object value, out object outputResult)
        {
            Type type = typeof(T);

            if (type == typeof(string))
            {
                outputResult = value.ToString();
                return true;
            }

            if (type == typeof(int))
            {
                bool tryParseResult = int.TryParse(value.ToString(), out int number);
                outputResult = number;
                return tryParseResult;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(value);

            if (converter.CanConvertTo(type))
            {
                outputResult = converter.ConvertTo(value, type);
                return true;
            }

            converter = TypeDescriptor.GetConverter(type);
            if (converter.CanConvertFrom(value.GetType()))
            {
                outputResult = converter.ConvertFrom(value);
                return true;
            }

            outputResult = default(T);
            return false;
        }

        public void Set<T>(string category, string key, T value, bool persist = true)
        {
            string index = CreateKey(category, key);
            _memory[index] = value;
        }

        public ConfiguratorRepresentation Clone()
        {
            return new ConfiguratorRepresentation()
            {
                _memory = new Dictionary<string, object>(_memory)
            };
        }

        internal Dictionary<string, object> GetItems()
        {
            return _memory;
        }

        public static string GetCategory(string index)
        {
            return index.Split(KeySeparator).First();
        }

        public static string GetKey(string index)
        {
            return index.Split(KeySeparator).Last();
        }
    }
}