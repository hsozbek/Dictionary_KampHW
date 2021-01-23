using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryKampHW
{
    class MyDictionary<T1,T2>
    {
        private T1[] _arrayKey;
        private T2[] _arrayValue;
        public MyDictionary()
        {
            _arrayKey = new T1[0];
            _arrayValue = new T2[0];
        }
        public void Add(T1 key,T2 value)
        {
            T1[] tempArrayKey;
            T2[] tempArrayValue;
            tempArrayKey = _arrayKey;
            tempArrayValue = _arrayValue;
            _arrayKey = new T1[tempArrayKey.Length+1];
            _arrayValue = new T2[tempArrayValue.Length+1];
            
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                _arrayKey[i] = tempArrayKey[i];

            }

            _arrayKey[_arrayKey.Length - 1] = key;

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                _arrayValue[i] = tempArrayValue[i];

            }

            _arrayValue[_arrayValue.Length - 1] = value;


        }
    }
}
