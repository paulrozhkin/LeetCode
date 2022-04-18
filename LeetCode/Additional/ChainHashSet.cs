using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Additional
{
    public class ChainHashSet<TKey, TValue>
    {
        private SequentialSearchSymbolTable<TKey, TValue>[] _chains;

        private const int DefaultCapacity = 4;

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public ChainHashSet(int capacity)
        {
            Capacity = capacity;
            _chains = new SequentialSearchSymbolTable<TKey, TValue>[capacity];
            for (int i = 0; i < capacity; i++)
            {
                _chains[i] = new SequentialSearchSymbolTable<TKey, TValue>();
            }
        }

        public ChainHashSet() : this(DefaultCapacity)
        {
        }

        private int Hash(TKey key)
        {
            return (key.GetHashCode() & 0x7fffffff) % Capacity;
        }

        public TValue Get(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var index = Hash(key);
            if (_chains[index].TryGet(key, out var value))
            {
                return value;
            }

            throw new ArgumentException("Keys not found");
        }

        public bool Contains(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var index = Hash(key);
            return _chains[index].Contains(key);
        }

        public bool Remove(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var index = Hash(key);
            if (_chains[index].Remove(key))
            {
                Count--;
                return true;
            }

            return false;
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (value == null)
            {
                Remove(key);
                return;
            }

            if (Count >= 10 * Capacity)
            {
                Resize(2 * Capacity);
            }

            var index = Hash(key);

            if (!_chains[index].Contains(key))
            {
                Count++;
            }

            _chains[index].Add(key, value);
        }

        private void Resize(int newSize)
        {
            var newChain = new ChainHashSet<TKey, TValue>(newSize);

            foreach (var chain in _chains)
            {
                foreach (var key in chain.Keys())
                {
                    if (chain.TryGet(key, out var value))
                    {
                        newChain.Add(key, value);
                    }
                }
            }

            Capacity = newChain.Capacity;
            Count = newChain.Count;
            _chains = newChain._chains;
        }

        public IEnumerable<TKey> Keys()
        {
            for (var i = 0; i < Capacity; i++)
            {
                foreach (var key in _chains[i].Keys())
                {
                    yield return key;
                }
            }
        }
    }
}
