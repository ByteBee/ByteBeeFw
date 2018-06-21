using System;
using System.Collections.Generic;
using System.Text;

namespace KukSoft.ToolKit.DataTypes
{
    public class Dictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TValue> : Dictionary<TKey1, TKey2, TKey3, TKey4, Dictionary<TKey5, TValue>>
    {
        public TValue this[TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5]
        {
            get => this[key1, key2, key3, key4][key5];
            set => this[key1, key2, key3, key4][key5] = value;
        }

        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TValue value)
        {
            if (!ContainsKey(key1, key2, key3, key4))
            {
                Add(key1, key2, key3, key4, new Dictionary<TKey5, TValue>());
            }

            this[key1, key2, key3, key4].Add(key5, value);
        }

        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
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

        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5) => this[key1, key2, key3, key4].Remove(key5);
    }
}
