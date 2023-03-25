using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class MyDictionary<TKey, TValue>
    {
        private const int DEFAULT_SIZE = 100;
        private TValue[] _values = new TValue[DEFAULT_SIZE]; 

        public TValue this[TKey key]
        {
            get => _values[Hash(key)];
            set => _values[Hash(key)] = value;
        }

        public void Add(TKey key, TValue value)
        {
            _values[Hash(key)] = value;
        }

        public void Remove(TKey key)
        {
            _values[Hash(key)] = default(TValue);
        }

        // out keyword
        // 함수가 반환될 떄 추가적으로 값을 더 반환할 때 사용하는 키워드
        public bool TryGetValue(TKey key, out TValue value)
        {
            value = default(TValue);

            // try-catch 구문
            // 예외잡기를 시도한느 구문. 예외가 던져질때 그 예외에 대해서 내가 직접 핸들링할때 사용
            try
            {
                value = _values[Hash(key)];
            }
            catch (Exception e) 
            {
                //throw e;
                Console.WriteLine($"Dictionary<{typeof(TKey).Name}, {typeof(TValue).Name}> : 유효하지않은 Key 값, {e.Message}");
                return false;
            }
            //finally
            //{
            // 예외를 잡던 안잡던 마지막에 반드시 실행할 내용
            //}

            return true;
        }


        private int Hash(TKey key)
        {
            string tmpString = key.ToString();
            int tmpHash = 0;

            for(int i = 0; i< tmpString.Length; i++)
            {
                tmpHash += tmpString[i];
            }
            tmpHash %= DEFAULT_SIZE;
            return tmpHash;
        }
    }
}
