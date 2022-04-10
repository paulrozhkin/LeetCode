using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetCode.Additional
{
    /// <summary>
    /// Symbol table based linked list
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class SequentialSearchSymbolTable<TKey, TValue>
    {
        #region Fields

        private SymbolTableNode _head;

        private readonly EqualityComparer<TKey> _equalityComparer;

        #endregion

        #region Consturctors

        public SequentialSearchSymbolTable()
        {
            _equalityComparer = EqualityComparer<TKey>.Default;
        }

        public SequentialSearchSymbolTable(EqualityComparer<TKey> equalityComparer)
        {
            if (_equalityComparer == null)
            {
                throw new ArgumentNullException(nameof(_equalityComparer));
            }

            _equalityComparer = equalityComparer;
        }

        #endregion

        #region Properties

        public int Count { get; private set; }

        #endregion


        #region Methods

        public bool TryGet(TKey key, out TValue value)
        {
            for (var node = _head; node != null; node = node.Next)
            {
                if (_equalityComparer.Equals(node.Key, key))
                {
                    value = node.Value;
                    return true;
                }
            }

            value = default;
            return false;
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            for (var node = _head; node != null; node = node.Next)
            {
                if (_equalityComparer.Equals(node.Key, key))
                {
                    node.Value = value;
                    return;
                }
            }

            _head = new SymbolTableNode(key, value, _head);
            Count++;
        }

        public bool Contains(TKey key)
        {
            for (var node = _head; node != null; node = node.Next)
            {
                if (_equalityComparer.Equals(node.Key, key))
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<TKey> Keys()
        {
            for (var node = _head; node != null; node = node.Next)
            {
                yield return node.Key;
            }
        }

        public bool Remove(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            SymbolTableNode prevNode = null;
            for (var node = _head; node != null; node = node.Next)
            {
                if (_equalityComparer.Equals(node.Key, key))
                {
                    if (node != _head)
                    {
                        Debug.Assert(prevNode != null, nameof(prevNode) + " != null");
                        prevNode.Next = node.Next;
                    }
                    else
                    {
                        _head = node.Next;
                    }

                    Count--;
                    return true;
                }

                prevNode = node;
            }

            return false;
        }

        #endregion

        #region Classes

        private class SymbolTableNode
        {
            public TKey Key { get; }

            public TValue Value { get; set; }

            public SymbolTableNode Next { get; set; }

            public SymbolTableNode(TKey key, TValue value, SymbolTableNode next)
            {
                Key = key;
                Value = value;
                Next = next;
            }
        }

        #endregion
    }
}