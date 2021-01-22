using System;
using System.Collections.Generic;
using System.Text;


namespace GenericIntro
{
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;


        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] _tempKeys = keys;
            V[] _tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
                values[i] = _tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public K[] Keys
        {
            get { return keys; }
        }


        public V[] Values
        {
            get { return values; }
        }

    }

}