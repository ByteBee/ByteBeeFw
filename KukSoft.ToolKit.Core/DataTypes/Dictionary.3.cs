using System.Collections.Generic;

namespace KukSoft.ToolKit.DataTypes
{
    public class Dictionary<TKey1, TKey2, TKey3, TValue> : Dictionary<TKey1, TKey2, Dictionary<TKey3, TValue>>
    {
        public TValue this[TKey1 key1, TKey2 key2, TKey3 key3]
        {
            get => this[key1][key2][key3];
            set => this[key1][key2][key3] = value;
        }

        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TValue value)
        {
            if (!ContainsKey(key1, key2))
            {
                Add(key1, key2, new Dictionary<TKey3, TValue>());
            }
            
            this[key1, key2].Add(key3, value);
        }

        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            if (!ContainsKey(key1))
            {
                return false;
            }
            else if (!this[key1].ContainsKey(key2))
            {
                return false;
            }
            else if (!this[key1, key2].ContainsKey(key3))
            {
                return false;
            }
            return true;
        }

        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3) => this[key1, key2].Remove(key3);
    }
}