using System.Collections.Generic;

namespace KukSoft.ToolKit.DataTypes
{
    public class Dictionary<TKey1, TKey2, TValue> : Dictionary<TKey1, Dictionary<TKey2, TValue>>
    {
        public TValue this[TKey1 key1, TKey2 key2]
        {
            get => this[key1][key2];
            set => this[key1][key2] = value;
        }

        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            if (!ContainsKey(key1))
            {
                Add(key1, new Dictionary<TKey2, TValue>());
            }

            this[key1].Add(key2, value);
        }

        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            if (!ContainsKey(key1))
            {
                return false;
            }
            else if (!this[key1].ContainsKey(key2))
            {
                return false;
            }

            return true;
        }

        public bool Remove(TKey1 key1, TKey2 key2) => this[key1].Remove(key2);
    }
}