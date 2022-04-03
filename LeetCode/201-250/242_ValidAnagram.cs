using System.Collections.Generic;
using System.Linq;

namespace LeetCode._201_250
{
    public class _242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            var aux = new int[26];
            foreach (var symbol in s) aux['z' - symbol] += 1;
            foreach (var symbol in t) aux['z' - symbol] -= 1;
            return aux.All(x => x == 0);
        }

        public bool IsAnagramUnicode(string s, string t)
        {
            var sDictionary = GetCountOfSymbols(s);
            var tDictionary = GetCountOfSymbols(t);

            if (sDictionary.Count != tDictionary.Count)
            {
                return false;
            }

            foreach (var symbol in sDictionary)
            {
                if (!tDictionary.TryGetValue(symbol.Key, out var countInTDict))
                {
                    return false;
                }

                if (symbol.Value != countInTDict)
                {
                    return false;
                }
            }

            return true;
        }

        private Dictionary<char, int> GetCountOfSymbols(string s)
        {
            var dictionary = new Dictionary<char, int>();
            foreach (var symbol in s)
            {
                if (dictionary.ContainsKey(symbol))
                {
                    dictionary[symbol] += 1;
                }
                else
                {
                    dictionary[symbol] = 1;
                }
            }

            return dictionary;
        }
    }
}