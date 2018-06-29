using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace KukSoft.ToolKit.DataTypes
{
    [Serializable]
    public class EnumNotFoundException : Exception
    {
        public EnumNotFoundException() { }
        public EnumNotFoundException(string message) : base(message) { }
        public EnumNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected EnumNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    public abstract class Enum<TEnum, TValue> where TEnum : Enum<TEnum, TValue>
    {
        private static readonly Lazy<TEnum[]> _allLazyMembers = new Lazy<TEnum[]>(() =>
        {
            Type t = typeof(TEnum);
            BindingFlags publicStatic = BindingFlags.Public | BindingFlags.Static;

            IEnumerable<TEnum> ofProp = t.GetProperties(publicStatic)
                .Where(p => t.IsAssignableFrom(p.PropertyType))
                .Select(i => (TEnum)i.GetValue(null));

            IEnumerable<TEnum> ofField = t.GetFields(publicStatic)
                .Where(f => t.IsAssignableFrom(f.FieldType))
                .Select(i => (TEnum)i.GetValue(null));

            return ofProp.Union(ofField).OrderBy(e => e.Value).ToArray();
        });

        public static TEnum[] GetAll() => _allLazyMembers.Value;

        public string Name { get; set; }
        public TValue Value { get; set; }

        protected Enum(TValue value, string name)
        {
            Name = name;
            Value = value;
        }

        protected Enum() { }

        public static TEnum ByName(string name)
        {
            Fancy.guard.AgainstNullOrWhiteSpace(name, nameof(name));

            TEnum result = GetAll().SingleOrDefault(item => string.Equals(item.Name, name, StringComparison.OrdinalIgnoreCase));
            if (result == null)
            {
                throw new EnumNotFoundException($"No {typeof(TEnum).Name} with Name \"{name}\" found.");
            }
            return result;
        }

        public static TEnum ByValue(TValue value)
        {
            TEnum result = GetAll().SingleOrDefault(item => EqualityComparer<TValue>.Default.Equals(item.Value, value));
            if (result == null)
            {
                throw new EnumNotFoundException($"No {typeof(TEnum).Name} with Value {value} found.");
            }
            return result;
        }

        public static TEnum ByValue(TValue value, TEnum defaultValue)
        {
            TEnum result = GetAll().SingleOrDefault(item => EqualityComparer<TValue>.Default.Equals(item.Value, value));
            if (result == null)
            {
                result = defaultValue;
            }
            return result;
        }

        public override string ToString() => $"{Name} ({Value})";

        public static implicit operator TValue(Enum<TEnum, TValue> @enum) => @enum.Value;
        public static explicit operator Enum<TEnum, TValue>(TValue value) => ByValue(value);
    }
}
