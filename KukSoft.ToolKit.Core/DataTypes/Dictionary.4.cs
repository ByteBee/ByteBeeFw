using System;
using System.Collections.Generic;
using System.Text;

namespace KukSoft.ToolKit.DataTypes
{
    public class Dictionary<TKey1, TKey2, TKey3, TKey4, TValue> : Dictionary<TKey1, TKey2, TKey3, Dictionary<TKey4, TValue>>
    {
        public TValue this[TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4]
        {
            get => this[key1, key2, key3][key4];
            set => this[key1, key2, key3][key4] = value;
        }

        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TValue value)
        {
            if (!ContainsKey(key1, key2, key3))
            {
                Add(key1, key2, key3, new Dictionary<TKey4, TValue>());
            }

            this[key1, key2, key3].Add(key4, value);
        }

        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
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

        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4) => this[key1, key2, key3].Remove(key4);
    }
}
