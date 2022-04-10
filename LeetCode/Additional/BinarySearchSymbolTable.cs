using System;
using System.Collections.Generic;

namespace LeetCode.Additional
{
    /// <summary>
    /// Symbol table based arrays and binary search
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class BinarySearchSymbolTable<TKey, TValue>
    {
        #region Fields

        private const int DefaultCapacity = 4;

        private readonly IComparer<TKey> _comparer;

        private TKey[] _keys;
        private TValue[] _values;

        #endregion

        #region Consturctors

        public BinarySearchSymbolTable(int capacity, IComparer<TKey> comparer)
        {
            _comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
            _keys = new TKey[capacity];
            _values = new TValue[capacity];
        }

        public BinarySearchSymbolTable() : this(DefaultCapacity, Comparer<TKey>.Default)
        {
        }

        public BinarySearchSymbolTable(int capacity) : this(capacity, Comparer<TKey>.Default)
        {
        }

        #endregion

        #region Properties

        public int Count { get; private set; }

        public int Capacity => _keys.Length;

        public bool IsEmpty => Count == 0;

        #endregion

        #region Methods

        public int Rank(TKey key)
        {
            int low = 0;
            int high = Count - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;

                var cmp = _comparer.Compare(key, _keys[mid]);
                if (cmp < 0)
                    high = mid - 1;
                else if (cmp > 0)
                    low = mid + 1;
                else
                    return mid;
            }

            return low;
        }

        public TValue GetValueOrDefault(TKey key)
        {
            if (IsEmpty)
            {
                return default;
            }

            var rank = Rank(key);
            if (rank < Count && _comparer.Compare(key, _keys[rank]) == 0)
            {
                return _values[rank];
            }

            return default;
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var rank = Rank(key);
            if (rank < Count && _comparer.Compare(key, _keys[rank]) == 0)
            {
                _values[rank] = value;
            }
            else
            {
                if (Count == Capacity)
                {
                    Resize(Capacity * 2);
                }

                for (var index = Count; index > rank; index--)
                {
                    _keys[index] = _keys[index - 1];
                    _values[index] = _values[index - 1];
                }

                _keys[rank] = key;
                _values[rank] = value;

                Count++;
            }
        }

        public bool Remove(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (IsEmpty)
            {
                return false;
            }

            var rank = Rank(key);
            if (rank < Count && _comparer.Compare(key, _keys[rank]) == 0)
            {
                for (var index = rank; index < Count - 1; index++)
                {
                    _keys[index] = _keys[index + 1];
                    _values[index] = _values[index + 1];
                }

                Count--;
                _keys[Count] = default;
                _values[Count] = default;

                return true;
            }

            return false;
        }

        public bool Contains(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (IsEmpty)
            {
                return false;
            }

            var rank = Rank(key);
            return rank < Count && _comparer.Compare(key, _keys[rank]) == 0;
        }

        public IEnumerable<TKey> Keys()
        {
            for (var i = 0; i < Count; i++)
            {
                yield return _keys[i];
            }
        }

        public TKey Min()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Table is empty.");

            return _keys[0];
        }

        public TKey Max()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Table is empty.");

            return _keys[Count - 1];
        }

        public bool RemoveMin()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Table is empty.");

            return Remove(_keys[0]);
        }

        public bool RemoveMax()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Table is empty.");

            return Remove(_keys[Count - 1]);
        }

        public TKey Select(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentException("Can't select since index is out of range.");
            return _keys[index];
        }

        public TKey Ceiling(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var r = Rank(key);
            return r == Count ? default : _keys[r];
        }

        public TKey Floor(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var r = Rank(key);
            if (r < Count && _comparer.Compare(_keys[r], key) == 0) return _keys[r];
            return r == 0 ? default : _keys[r - 1];
        }

        public IEnumerable<TKey> Range(TKey keyFrom, TKey keyTo)
        {
            var rFrom = Rank(keyFrom);
            var rTo = Rank(keyTo);

            if (rTo == Count - 1 && _comparer.Compare(keyTo, _keys[Count - 1]) == 0)
                rTo++;

            for (var i = rFrom; i < rTo; i++)
            {
                yield return _keys[i];
            }
        }

        private void Resize(int capacity)
        {
            var newKeys = new TKey[capacity];
            var newValues = new TValue[capacity];

            Array.Copy(_keys, newKeys, Count);
            Array.Copy(_values, newValues, Count);
            _keys = newKeys;
            _values = newValues;
        }

        #endregion
    }
}